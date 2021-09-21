Public Class TrussDrawer
    Friend caller As plugin
    Dim nf As NextFEMapi.API

    Private Sub TrussDrawer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nf = caller.API ' short alias for caller.API

        ' loads materials and sections
        mats.Items.Clear()
        For Each st In nf.getMaterialsLibrary
            mats.Items.Add(st)
        Next
        sects.Items.Clear()
        For Each st In nf.getSectionsLibrary
            sects.Items.Add(st)
        Next
    End Sub

    ' clear selection on screen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nf.clearSelection()
        caller.RequestScreenUpdate(caller, False, NextFEMplugin.ViewState.NoOperation) ' do not change view
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hei.Value = span.Value / 15
        wid.Value = span.Value / bays.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' call undo
        caller.RequestUndo(NextFEMplugin.undoOps.Normal)
        ' Draw structure using APIs
        Dim w As Double = wid.Value
        Dim h As Double = hei.Value
        Dim stand As New List(Of Drawing.Point) ' use this to store node number of vertical trusses
        For i = 0 To bays.Value
            stand.Add(New Drawing.Point(nf.addNode(i * w, 0, 0), nf.addNode(i * w, 0, h)))
        Next
        ' section and material
        Dim sect As Integer = If(sects.SelectedItem <> "", nf.addSectFromLib(sects.SelectedItem), 0)
        Dim mat As Integer = If(mats.SelectedItem <> "", nf.addMatFromLib(mats.SelectedItem), 0)
        For i = 0 To stand.Count - 1
            Dim st As Drawing.Point = stand(i)
            ' vertical trusses
            nf.addTruss(st.X, st.Y, sect, mat)
            ' horizontal trusses
            If i > 0 Then
                nf.addTruss(st.X, stand(i - 1).X, sect, mat)
                nf.addTruss(st.Y, stand(i - 1).Y, sect, mat)
                ' diagonals
                nf.addTruss(st.X, stand(i - 1).Y, sect, mat)
            End If
        Next
        ' refresh the view
        caller.RequestScreenUpdate(caller, True, NextFEMplugin.ViewState.NoOperation)
    End Sub
End Class