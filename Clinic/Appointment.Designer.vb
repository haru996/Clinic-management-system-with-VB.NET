<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtTimeStart = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTimeStart = New System.Windows.Forms.ComboBox()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.cmbTimeEnd = New System.Windows.Forms.ComboBox()
        Me.txtTimeEnd = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNurseID = New System.Windows.Forms.TextBox()
        Me.lblScheduleID = New System.Windows.Forms.Label()
        Me.epText = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.epText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doctor Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time Start:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Patient ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(170, 359)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtDoctorID
        '
        Me.txtDoctorID.Location = New System.Drawing.Point(86, 38)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(100, 20)
        Me.txtDoctorID.TabIndex = 7
        Me.txtDoctorID.Tag = "Please Enter Doctor ID"
        '
        'dtPicker
        '
        Me.dtPicker.Location = New System.Drawing.Point(78, 109)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(200, 20)
        Me.dtPicker.TabIndex = 9
        Me.dtPicker.Value = New Date(2017, 11, 12, 23, 7, 24, 0)
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(83, 224)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(100, 20)
        Me.txtPatientID.TabIndex = 11
        Me.txtPatientID.Tag = "Please Enter Patient ID"
        '
        'txtTimeStart
        '
        Me.txtTimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeStart.Location = New System.Drawing.Point(78, 152)
        Me.txtTimeStart.Mask = "90:00"
        Me.txtTimeStart.Name = "txtTimeStart"
        Me.txtTimeStart.Size = New System.Drawing.Size(51, 20)
        Me.txtTimeStart.TabIndex = 12
        Me.txtTimeStart.Tag = "Please Enter Time Start"
        Me.txtTimeStart.ValidatingType = GetType(Date)
        '
        'cmbTimeStart
        '
        Me.cmbTimeStart.FormattingEnabled = True
        Me.cmbTimeStart.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTimeStart.Location = New System.Drawing.Point(143, 151)
        Me.cmbTimeStart.Name = "cmbTimeStart"
        Me.cmbTimeStart.Size = New System.Drawing.Size(43, 21)
        Me.cmbTimeStart.TabIndex = 13
        Me.cmbTimeStart.Tag = "Please Select Time Start"
        '
        'lblPatient
        '
        Me.lblPatient.AutoSize = True
        Me.lblPatient.Location = New System.Drawing.Point(12, 263)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(43, 13)
        Me.lblPatient.TabIndex = 14
        Me.lblPatient.Text = "Patient:"
        '
        'txtDoctorName
        '
        Me.txtDoctorName.Location = New System.Drawing.Point(86, 75)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(100, 20)
        Me.txtDoctorName.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Schedule ID:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(75, 263)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(39, 13)
        Me.lblPatientName.TabIndex = 17
        Me.lblPatientName.Text = "Label7"
        '
        'cmbTimeEnd
        '
        Me.cmbTimeEnd.FormattingEnabled = True
        Me.cmbTimeEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTimeEnd.Location = New System.Drawing.Point(143, 190)
        Me.cmbTimeEnd.Name = "cmbTimeEnd"
        Me.cmbTimeEnd.Size = New System.Drawing.Size(43, 21)
        Me.cmbTimeEnd.TabIndex = 20
        Me.cmbTimeEnd.Tag = "Please Select Time End"
        '
        'txtTimeEnd
        '
        Me.txtTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeEnd.Location = New System.Drawing.Point(78, 190)
        Me.txtTimeEnd.Mask = "90:00"
        Me.txtTimeEnd.Name = "txtTimeEnd"
        Me.txtTimeEnd.Size = New System.Drawing.Size(51, 20)
        Me.txtTimeEnd.TabIndex = 19
        Me.txtTimeEnd.Tag = "Please Enter Time End"
        Me.txtTimeEnd.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Time End:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nurse ID:"
        '
        'txtNurseID
        '
        Me.txtNurseID.Location = New System.Drawing.Point(78, 299)
        Me.txtNurseID.Name = "txtNurseID"
        Me.txtNurseID.Size = New System.Drawing.Size(100, 20)
        Me.txtNurseID.TabIndex = 22
        Me.txtNurseID.Tag = "Please Enter Nurse ID"
        '
        'lblScheduleID
        '
        Me.lblScheduleID.AutoSize = True
        Me.lblScheduleID.Location = New System.Drawing.Point(87, 9)
        Me.lblScheduleID.Name = "lblScheduleID"
        Me.lblScheduleID.Size = New System.Drawing.Size(39, 13)
        Me.lblScheduleID.TabIndex = 23
        Me.lblScheduleID.Text = "Label9"
        '
        'epText
        '
        Me.epText.ContainerControl = Me
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 394)
        Me.Controls.Add(Me.lblScheduleID)
        Me.Controls.Add(Me.txtNurseID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbTimeEnd)
        Me.Controls.Add(Me.txtTimeEnd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.cmbTimeStart)
        Me.Controls.Add(Me.txtTimeStart)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.dtPicker)
        Me.Controls.Add(Me.txtDoctorName)
        Me.Controls.Add(Me.txtDoctorID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Appointment"
        Me.Text = "Appointment"
        CType(Me.epText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents txtTimeStart As MaskedTextBox
    Friend WithEvents cmbTimeStart As ComboBox
    Friend WithEvents lblPatient As Label
    Friend WithEvents txtDoctorName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents cmbTimeEnd As ComboBox
    Friend WithEvents txtTimeEnd As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNurseID As TextBox
    Friend WithEvents lblScheduleID As Label
    Friend WithEvents epText As ErrorProvider
End Class
