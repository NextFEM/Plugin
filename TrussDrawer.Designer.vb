<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrussDrawer
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrussDrawer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bays = New System.Windows.Forms.NumericUpDown()
        Me.span = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.hei = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.wid = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mats = New System.Windows.Forms.ComboBox()
        Me.sects = New System.Windows.Forms.ComboBox()
        CType(Me.bays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.span, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(23, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear selection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bays"
        '
        'bays
        '
        Me.bays.Location = New System.Drawing.Point(102, 51)
        Me.bays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.bays.Name = "bays"
        Me.bays.Size = New System.Drawing.Size(83, 20)
        Me.bays.TabIndex = 2
        Me.bays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bays.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'span
        '
        Me.span.DecimalPlaces = 5
        Me.span.Location = New System.Drawing.Point(102, 75)
        Me.span.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.span.Name = "span"
        Me.span.Size = New System.Drawing.Size(83, 20)
        Me.span.TabIndex = 4
        Me.span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.span.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total span"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(23, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Suggest height and lenght"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'hei
        '
        Me.hei.DecimalPlaces = 5
        Me.hei.Location = New System.Drawing.Point(102, 129)
        Me.hei.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.hei.Name = "hei"
        Me.hei.Size = New System.Drawing.Size(83, 20)
        Me.hei.TabIndex = 7
        Me.hei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hei.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Height"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(28, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Draw truss structure"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'wid
        '
        Me.wid.DecimalPlaces = 5
        Me.wid.Location = New System.Drawing.Point(102, 155)
        Me.wid.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.wid.Name = "wid"
        Me.wid.Size = New System.Drawing.Size(83, 20)
        Me.wid.TabIndex = 10
        Me.wid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.wid.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Span lenght"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Section"
        '
        'mats
        '
        Me.mats.FormattingEnabled = True
        Me.mats.Location = New System.Drawing.Point(75, 185)
        Me.mats.Name = "mats"
        Me.mats.Size = New System.Drawing.Size(110, 21)
        Me.mats.TabIndex = 13
        '
        'sects
        '
        Me.sects.FormattingEnabled = True
        Me.sects.Location = New System.Drawing.Point(75, 211)
        Me.sects.Name = "sects"
        Me.sects.Size = New System.Drawing.Size(110, 21)
        Me.sects.TabIndex = 14
        '
        'TrussDrawer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 273)
        Me.Controls.Add(Me.sects)
        Me.Controls.Add(Me.mats)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.wid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.hei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.span)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bays)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrussDrawer"
        Me.ShowInTaskbar = False
        Me.Text = "TrussDrawer"
        CType(Me.bays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.span, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bays As System.Windows.Forms.NumericUpDown
    Friend WithEvents span As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents hei As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents wid As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mats As System.Windows.Forms.ComboBox
    Friend WithEvents sects As System.Windows.Forms.ComboBox
End Class
