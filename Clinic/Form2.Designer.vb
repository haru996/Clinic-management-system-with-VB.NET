<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBP = New System.Windows.Forms.MaskedTextBox()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.DateTimePicker()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComplaints = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMedicine = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTreatment = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtNurseID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRecPatientID = New System.Windows.Forms.Label()
        Me.lblRecPatientName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtLaboratory = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtNurse = New System.Windows.Forms.TextBox()
        Me.epTxtBox = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblRecordID = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.epTxtBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1229, 55)
        Me.Panel4.TabIndex = 288
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(3, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(209, 26)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "_ TREATMENT RECORD"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(1204, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "X"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(582, 186)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 18)
        Me.Label26.TabIndex = 433
        Me.Label26.Text = "Celcius"
        '
        'txtBP
        '
        Me.txtBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBP.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtBP.Location = New System.Drawing.Point(150, 213)
        Me.txtBP.Mask = "000/000"
        Me.txtBP.Name = "txtBP"
        Me.txtBP.Size = New System.Drawing.Size(80, 26)
        Me.txtBP.TabIndex = 396
        Me.txtBP.Tag = "Please enter patient's blood pressure"
        '
        'txtDoctorID
        '
        Me.txtDoctorID.BackColor = System.Drawing.SystemColors.Control
        Me.txtDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorID.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDoctorID.Location = New System.Drawing.Point(818, 237)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(84, 26)
        Me.txtDoctorID.TabIndex = 408
        Me.txtDoctorID.Tag = "Please enter patient's doctor"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(648, 241)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 18)
        Me.Label23.TabIndex = 431
        Me.Label23.Text = "Attending Doctor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 427
        Me.Label2.Text = "Date and Time:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(117, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 18)
        Me.Label19.TabIndex = 426
        Me.Label19.Text = "Record ID:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(648, 171)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 18)
        Me.Label17.TabIndex = 425
        Me.Label17.Text = "Laboratory:"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(648, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 18)
        Me.Label18.TabIndex = 424
        Me.Label18.Text = "Treatment:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(648, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "Laboratory:"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDiagnosis.BackColor = System.Drawing.SystemColors.Info
        Me.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDiagnosis.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDiagnosis.Location = New System.Drawing.Point(119, 249)
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.Size = New System.Drawing.Size(469, 26)
        Me.txtDiagnosis.TabIndex = 400
        Me.txtDiagnosis.Tag = "Please enter patient's diagnosis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(10, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 18)
        Me.Label15.TabIndex = 420
        Me.Label15.Text = "Diagnosis:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(116, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 18)
        Me.Label11.TabIndex = 416
        Me.Label11.Text = "BP:"
        '
        'txtTemperature
        '
        Me.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtTemperature.Location = New System.Drawing.Point(511, 176)
        Me.txtTemperature.MaxLength = 2
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(70, 26)
        Me.txtTemperature.TabIndex = 395
        Me.txtTemperature.Tag = "Please enter patient's temperature"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(413, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 18)
        Me.Label14.TabIndex = 415
        Me.Label14.Text = "Temperature:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(381, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 18)
        Me.Label8.TabIndex = 414
        Me.Label8.Text = "cm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(240, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 413
        Me.Label9.Text = "Height:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(206, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 412
        Me.Label7.Text = "kgs"
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtTime.Location = New System.Drawing.Point(409, 103)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(226, 26)
        Me.txtTime.TabIndex = 391
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(120, 103)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(283, 26)
        Me.txtDate.TabIndex = 390
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(648, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 411
        Me.Label3.Text = "Prescriptions:"
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtWeight.Location = New System.Drawing.Point(120, 176)
        Me.txtWeight.MaxLength = 2
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(84, 26)
        Me.txtWeight.TabIndex = 393
        Me.txtWeight.Tag = "Please enter patient's weight"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "Weight:"
        '
        'txtComplaints
        '
        Me.txtComplaints.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtComplaints.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComplaints.BackColor = System.Drawing.SystemColors.Info
        Me.txtComplaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplaints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtComplaints.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtComplaints.Location = New System.Drawing.Point(120, 135)
        Me.txtComplaints.MaxLength = 100
        Me.txtComplaints.Name = "txtComplaints"
        Me.txtComplaints.Size = New System.Drawing.Size(515, 26)
        Me.txtComplaints.TabIndex = 392
        Me.txtComplaints.Tag = "Please enter patient's complaints"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(11, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 409
        Me.Label12.Text = "Complaints:"
        '
        'txtMedicine
        '
        Me.txtMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMedicine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMedicine.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtMedicine.Location = New System.Drawing.Point(778, 103)
        Me.txtMedicine.Name = "txtMedicine"
        Me.txtMedicine.Size = New System.Drawing.Size(392, 26)
        Me.txtMedicine.TabIndex = 404
        Me.txtMedicine.Tag = "Please enter patient's medicine"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(648, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 18)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Medicine/ Dosage:"
        '
        'txtTreatment
        '
        Me.txtTreatment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTreatment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTreatment.BackColor = System.Drawing.SystemColors.Info
        Me.txtTreatment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTreatment.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtTreatment.Location = New System.Drawing.Point(755, 135)
        Me.txtTreatment.Name = "txtTreatment"
        Me.txtTreatment.Size = New System.Drawing.Size(463, 26)
        Me.txtTreatment.TabIndex = 405
        Me.txtTreatment.Tag = "Please enter patient's treatement"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 78)
        Me.Panel2.TabIndex = 434
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(1025, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 30)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(1125, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 30)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtNurseID
        '
        Me.txtNurseID.BackColor = System.Drawing.SystemColors.Control
        Me.txtNurseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNurseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseID.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNurseID.Location = New System.Drawing.Point(818, 290)
        Me.txtNurseID.Name = "txtNurseID"
        Me.txtNurseID.Size = New System.Drawing.Size(84, 26)
        Me.txtNurseID.TabIndex = 435
        Me.txtNurseID.Tag = "Please enter your nurse ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(648, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 436
        Me.Label4.Text = "Attending Nurse:"
        '
        'lblRecPatientID
        '
        Me.lblRecPatientID.AutoSize = True
        Me.lblRecPatientID.Location = New System.Drawing.Point(186, 310)
        Me.lblRecPatientID.Name = "lblRecPatientID"
        Me.lblRecPatientID.Size = New System.Drawing.Size(57, 13)
        Me.lblRecPatientID.TabIndex = 437
        Me.lblRecPatientID.Text = "Patient ID:"
        '
        'lblRecPatientName
        '
        Me.lblRecPatientName.AutoSize = True
        Me.lblRecPatientName.Location = New System.Drawing.Point(188, 350)
        Me.lblRecPatientName.Name = "lblRecPatientName"
        Me.lblRecPatientName.Size = New System.Drawing.Size(46, 13)
        Me.lblRecPatientName.TabIndex = 438
        Me.lblRecPatientName.Text = "Patient: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(103, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 439
        Me.Label10.Text = "Patient ID:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(106, 350)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 440
        Me.Label13.Text = "Patient"
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtHeight.Location = New System.Drawing.Point(299, 176)
        Me.txtHeight.MaxLength = 2
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(84, 26)
        Me.txtHeight.TabIndex = 445
        Me.txtHeight.Tag = "Please enter patient's height"
        '
        'txtLaboratory
        '
        Me.txtLaboratory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLaboratory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLaboratory.BackColor = System.Drawing.SystemColors.Info
        Me.txtLaboratory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLaboratory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLaboratory.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtLaboratory.Location = New System.Drawing.Point(755, 167)
        Me.txtLaboratory.Name = "txtLaboratory"
        Me.txtLaboratory.Size = New System.Drawing.Size(463, 26)
        Me.txtLaboratory.TabIndex = 450
        Me.txtLaboratory.Tag = "Please enter patient's laboratory"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Info
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtRemarks.Location = New System.Drawing.Point(755, 199)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(463, 26)
        Me.txtRemarks.TabIndex = 451
        Me.txtRemarks.Tag = "Please enter patient's remarks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(647, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 19)
        Me.Label16.TabIndex = 452
        Me.Label16.Text = "Remarks:"
        '
        'txtDoctor
        '
        Me.txtDoctor.BackColor = System.Drawing.SystemColors.Control
        Me.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDoctor.Location = New System.Drawing.Point(934, 237)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(283, 26)
        Me.txtDoctor.TabIndex = 453
        '
        'txtNurse
        '
        Me.txtNurse.BackColor = System.Drawing.SystemColors.Control
        Me.txtNurse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNurse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurse.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNurse.Location = New System.Drawing.Point(934, 290)
        Me.txtNurse.Name = "txtNurse"
        Me.txtNurse.Size = New System.Drawing.Size(283, 26)
        Me.txtNurse.TabIndex = 454
        '
        'epTxtBox
        '
        Me.epTxtBox.ContainerControl = Me
        '
        'lblRecordID
        '
        Me.lblRecordID.AutoSize = True
        Me.lblRecordID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecordID.Location = New System.Drawing.Point(206, 63)
        Me.lblRecordID.Name = "lblRecordID"
        Me.lblRecordID.Size = New System.Drawing.Size(80, 18)
        Me.lblRecordID.TabIndex = 455
        Me.lblRecordID.Text = "lblRecordID"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 500)
        Me.Controls.Add(Me.lblRecordID)
        Me.Controls.Add(Me.txtNurse)
        Me.Controls.Add(Me.txtDoctor)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtLaboratory)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblRecPatientName)
        Me.Controls.Add(Me.lblRecPatientID)
        Me.Controls.Add(Me.txtNurseID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtBP)
        Me.Controls.Add(Me.txtDoctorID)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDiagnosis)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComplaints)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMedicine)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTreatment)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.epTxtBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txtBP As MaskedTextBox
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTime As DateTimePicker
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtComplaints As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMedicine As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTreatment As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtNurseID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRecPatientID As Label
    Friend WithEvents lblRecPatientName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtLaboratory As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDoctor As TextBox
    Friend WithEvents txtNurse As TextBox
    Friend WithEvents epTxtBox As ErrorProvider
    Friend WithEvents lblRecordID As Label
End Class
