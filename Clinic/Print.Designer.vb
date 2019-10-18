<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDiagnosis = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblPersonContact = New System.Windows.Forms.Label()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.printMC = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblPrint = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clinic.My.Resources.Resources.medical_certificate_template_555
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(676, 531)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(37, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "IC"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(217, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(443, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Civil Status"
        '
        'lblDiagnosis
        '
        Me.lblDiagnosis.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosis.Location = New System.Drawing.Point(463, 499)
        Me.lblDiagnosis.Name = "lblDiagnosis"
        Me.lblDiagnosis.Size = New System.Drawing.Size(142, 17)
        Me.lblDiagnosis.TabIndex = 11
        Me.lblDiagnosis.Text = "Label1"
        '
        'lblIC
        '
        Me.lblIC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIC.Location = New System.Drawing.Point(87, 328)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(124, 13)
        Me.lblIC.TabIndex = 12
        Me.lblIC.Text = "Label1"
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGender.Location = New System.Drawing.Point(274, 328)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(169, 13)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Label1"
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCivilStatus.Location = New System.Drawing.Point(511, 328)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(135, 13)
        Me.lblCivilStatus.TabIndex = 14
        Me.lblCivilStatus.Text = "Label1"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAddress.Location = New System.Drawing.Point(39, 267)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(135, 13)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.Location = New System.Drawing.Point(105, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(135, 13)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Label1"
        '
        'lblFirstname
        '
        Me.lblFirstname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFirstname.Location = New System.Drawing.Point(123, 207)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(135, 13)
        Me.lblFirstname.TabIndex = 17
        Me.lblFirstname.Text = "Label1"
        '
        'lblLastname
        '
        Me.lblLastname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLastname.Location = New System.Drawing.Point(470, 207)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(135, 13)
        Me.lblLastname.TabIndex = 18
        Me.lblLastname.Text = "Label1"
        '
        'lblContactNo
        '
        Me.lblContactNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContactNo.Location = New System.Drawing.Point(73, 361)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(135, 13)
        Me.lblContactNo.TabIndex = 19
        Me.lblContactNo.Text = "Label1"
        '
        'lblPersonContact
        '
        Me.lblPersonContact.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPersonContact.Location = New System.Drawing.Point(440, 361)
        Me.lblPersonContact.Name = "lblPersonContact"
        Me.lblPersonContact.Size = New System.Drawing.Size(135, 13)
        Me.lblPersonContact.TabIndex = 20
        Me.lblPersonContact.Text = "Label1"
        '
        'lblDoctor
        '
        Me.lblDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctor.Location = New System.Drawing.Point(180, 444)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(117, 13)
        Me.lblDoctor.TabIndex = 21
        Me.lblDoctor.Text = "Label1"
        '
        'printMC
        '
        Me.printMC.DocumentName = "document"
        Me.printMC.Form = Me
        Me.printMC.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.printMC.PrinterSettings = CType(resources.GetObject("printMC.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printMC.PrintFileName = Nothing
        '
        'lblPrint
        '
        Me.lblPrint.Location = New System.Drawing.Point(545, 22)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(75, 23)
        Me.lblPrint.TabIndex = 22
        Me.lblPrint.Text = "Print"
        Me.lblPrint.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 530)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.lblPersonContact)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCivilStatus)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.lblDiagnosis)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Print"
        Me.Text = "Print"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDiagnosis As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblCivilStatus As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblPersonContact As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents printMC As PowerPacks.Printing.PrintForm
    Friend WithEvents lblPrint As Button
End Class
