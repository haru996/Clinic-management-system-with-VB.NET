Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim patientcat As String
    Dim intMaxRows As Integer
    Dim intRec As Integer
    Dim record As Integer
    Dim datetext As String

    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)

            If ctl(i).text = "" Then
                epTxtBox.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub ptsmiSave_Click(sender As Object, e As EventArgs) Handles ptsmiSave.Click

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        If vld(txtLastName, txtFirstName, txtIC, cmbCs, cmbGender, txtAge, txtContactno, txtHomeAdd, txtEmail, txtContactPerson, txtContactNoP) = False Then
            Exit Sub


        Else

            Try
                strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
                strSQL = "INSERT INTO patient1(PatientID,LastName,FirstName,PatientIC,PatientCivilStatus,PatientGender,PatientAge,PatientContactNo,PatientHomeAddress,PatientEmail,PatientContactPerson,PatientContactPersonNo,PatientCategory)VALUES('" & lblID.Text & "','" & txtLastName.Text & "','" & txtFirstName.Text & "','" & txtIC.Text & "','" & cmbCs.Text & "','" & cmbGender.Text & "','" & txtAge.Text & "','" & txtContactno.Text & "','" & txtHomeAdd.Text & "','" & txtEmail.Text & "','" & txtContactPerson.Text & "','" & txtContactNoP.Text & "','" & patientcat & "')"
                sqlCnn = New SqlConnection(strConnectionString)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)

                If sqlCmd.ExecuteNonQuery() Then

                    MessageBox.Show("Registration successfull")
                Else
                    MessageBox.Show("Fail")
                End If
                sqlCmd.Dispose()
                sqlCnn.Close()
            Catch ex As Exception
                MsgBox("Can not open connection !!")
            End Try


        End If
        autogeneratid()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerText.Enabled = True
        autogeneratid()
        autogeneratePaymentid()
    End Sub






    Private Sub radChild_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged
        patientcat = "Child"
    End Sub

    Private Sub radAdult_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged
        patientcat = "Adult"
    End Sub

    Private Sub radSenior_CheckedChanged(sender As Object, e As EventArgs) Handles radSenior.CheckedChanged
        patientcat = "Senior Citizen"
    End Sub

    Private Sub txtIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtIDSearch.TextChanged
        lvImage.Clear()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        Dim obj As New Form2


        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        If tabMenu.SelectedTab Is TabPage1 Then
            strSQL = "Select * from patient1 Where PatientID= '" & txtIDSearch.Text & "'"

            sqlCnn = New SqlConnection(strConnectionString)
            Try
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)
                adapter.SelectCommand = sqlCmd
                adapter.Fill(ds)
                intMaxRows = ds.Tables(0).Rows.Count
                For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                    lblID.Text = ds.Tables(0).Rows(intRecCount).Item(0)
                    txtLastName.Text = ds.Tables(0).Rows(intRecCount).Item(1)
                    txtFirstName.Text = ds.Tables(0).Rows(intRecCount).Item(2)
                    txtIC.Text = ds.Tables(0).Rows(intRecCount).Item(3)
                    cmbCs.Text = ds.Tables(0).Rows(intRecCount).Item(4)
                    cmbGender.Text = ds.Tables(0).Rows(intRecCount).Item(5)
                    txtAge.Text = ds.Tables(0).Rows(intRecCount).Item(6)
                    txtContactno.Text = ds.Tables(0).Rows(intRecCount).Item(7)
                    txtHomeAdd.Text = ds.Tables(0).Rows(intRecCount).Item(8)
                    txtEmail.Text = ds.Tables(0).Rows(intRecCount).Item(9)
                    txtContactPerson.Text = ds.Tables(0).Rows(intRecCount).Item(10)
                    txtContactNoP.Text = ds.Tables(0).Rows(intRecCount).Item(11)
                    txtCategory.Text = ds.Tables(0).Rows(intRecCount).Item(12)

                    Dim patcategory As String
                    patcategory = Trim(ds.Tables(0).Rows(intRecCount).Item(12))
                    If patcategory = "Child" Then
                        radChild.Checked = True
                    ElseIf patcategory = "Adult" Then
                        radAdult.Checked = True
                    Else
                        radSenior.Checked = True
                    End If

                Next
                adapter.Dispose()
                sqlCmd.Dispose()
                sqlCnn.Close()

            Catch ex As Exception
                MsgBox("Can not open connection ! ")
            End Try
            txtLastName.ReadOnly = True
            txtFirstName.ReadOnly = True
            txtIC.ReadOnly = True
            cmbCs.Enabled = False
            cmbGender.Enabled = False
            txtAge.ReadOnly = True
            txtContactno.ReadOnly = True
            txtHomeAdd.ReadOnly = True
            txtEmail.ReadOnly = True
            txtContactPerson.ReadOnly = True
            txtContactNoP.ReadOnly = True
            txtCategory.Enabled = False
            radAdult.Enabled = False
            radChild.Enabled = False
            radSenior.Enabled = False


        ElseIf tabMenu.SelectedTab Is TabPage3 Then
            Dim img As ListViewItem
            'strSQL = "Select * from record where PatientID='" & txtIDSearch.Text & "'"

            strSQL = "Select R.RecordID, R.RecordDate, R.RecordTime, R.RecordComplaints, R.RecordWeight, R.RecordHeight, R.RecordTemperature,
                    R.RecordBP, R.RecordDiagnosis, R.RecordMedicine, R.RecordTreatment, R.RecordLaboratory, R.RecordRemarks,
                    P.LastName, P.FirstName, N.NurseName, D.DoctorName from record R
                    INNER JOIN patient1 P ON P.PatientID = R.PatientID 
                    INNER JOIN nurse N ON N.NurseID = R.NurseID 
                    INNER JOIN doctor D ON D.DoctorID = R.DoctorID 
                    Where R.PatientID = '" & txtIDSearch.Text & "'"




            lvImage.View = View.SmallIcon
            sqlCnn = New SqlConnection(strConnectionString)
            Try
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)
                adapter.SelectCommand = sqlCmd
                adapter.Fill(ds)
                intMaxRows = ds.Tables(0).Rows.Count

                For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                    img = lvImage.Items.Add(ds.Tables(0).Rows(intRecCount).Item(3).ToString & "," & ds.Tables(0).Rows(intRecCount).Item(1).ToString & "," & ds.Tables(0).Rows(intRecCount).Item(2).ToString, 0)
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(0))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(1))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(2))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(3))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(4))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(5))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(6))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(7))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(8))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(9))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(10))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(11))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(12))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(13))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(14))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(15))
                    img.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(16))




                Next



            Catch ex As Exception
                MsgBox("Can not open connection ! ")
            End Try
        ElseIf tabMenu.SelectedTab Is TabPage4 Then

        ElseIf tabMenu.SelectedTab Is TabPage5 Then


            Try
                strSQL = "Select * from patient1 Where PatientID= '" & txtIDSearch.Text & "'"

                sqlCnn = New SqlConnection(strConnectionString)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)
                adapter.SelectCommand = sqlCmd
                adapter.Fill(ds)
                intMaxRows = ds.Tables(0).Rows.Count
                For intRecCount = 0 To ds.Tables(0).Rows.Count - 1

                    lblName.Text = ds.Tables(0).Rows(intRecCount).Item(1) + "" + ds.Tables(0).Rows(intRecCount).Item(2)
                    lblAge.Text = ds.Tables(0).Rows(intRecCount).Item(6)
                    lblContactNo.Text = ds.Tables(0).Rows(intRecCount).Item(7)
                    lblAddress.Text = ds.Tables(0).Rows(intRecCount).Item(8)




                Next
                adapter.Dispose()
                sqlCmd.Dispose()
                sqlCnn.Close()

            Catch ex As Exception
                MsgBox("Can not open connection ! ")
            End Try


        End If
    End Sub
    Private Sub lvImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvImage.SelectedIndexChanged

        lblReportID.Text = lvImage.FocusedItem.SubItems.Item(1).Text
        lblDateTime.Text = lvImage.FocusedItem.SubItems.Item(2).Text & " , " & lvImage.FocusedItem.SubItems.Item(3).Text
        lblDiagnosis.Text = lvImage.FocusedItem.SubItems.Item(9).Text
        txtComplaints.Text = lvImage.FocusedItem.SubItems.Item(4).Text
        lblWeight.Text = lvImage.FocusedItem.SubItems.Item(5).Text
        lblHeight.Text = lvImage.FocusedItem.SubItems.Item(6).Text
        lblTemperature.Text = lvImage.FocusedItem.SubItems.Item(7).Text
        lblBp.Text = lvImage.FocusedItem.SubItems.Item(8).Text
        txtMedicine.Text = lvImage.FocusedItem.SubItems.Item(10).Text
        txtLab.Text = lvImage.FocusedItem.SubItems.Item(10).Text
        txtTreatment.Text = lvImage.FocusedItem.SubItems.Item(11).Text
        txtRemarks.Text = lvImage.FocusedItem.SubItems.Item(12).Text
        lblNurse.Text = lvImage.FocusedItem.SubItems.Item(16).Text
        lblDoctor.Text = lvImage.FocusedItem.SubItems.Item(17).Text
        datetext = lvImage.FocusedItem.SubItems.Item(2).Text




    End Sub
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        Dim f2 As New Form2


        f2.lblRecPatientID.Text = txtIDSearch.Text
        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from patient1 Where PatientID= '" & txtIDSearch.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)
            intMaxRows = ds.Tables(0).Rows.Count

            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                f2.lblRecPatientName.Text = ds.Tables(0).Rows(intRecCount).Item(1) & "" & ds.Tables(0).Rows(intRecCount).Item(2)

            Next
            adapter.Dispose()
            sqlCmd.Dispose()
            sqlCnn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        f2.Show()
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Appointment.Show()
    End Sub

    Private Sub txtDoctorID_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorID.TextChanged
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        Dim schedule As ListViewItem
        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select S.ScheduleID, S.ScheduleDate, S.ScheduleTimeStart, S.ScheduleTimeEnd, D.DoctorName, P.LastName, P.FirstName from schedule S 
                    INNER JOIN patient1 P ON P.PatientID = S.PatientID
                    INNER JOIN doctor D ON D.DoctorID = S.DoctorID
                    Where S.DoctorID= '" & txtDoctorID.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)
            intMaxRows = ds.Tables(0).Rows.Count
            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                schedule = lvSchedule.Items.Add(ds.Tables(0).Rows(intRecCount).Item(0))
                schedule.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(4))
                schedule.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(1))
                schedule.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(2))
                schedule.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(3))
                schedule.SubItems.Add(ds.Tables(0).Rows(intRecCount).Item(5) + " " + ds.Tables(0).Rows(intRecCount).Item(6))
            Next
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub


    'Private Sub lblNurse_TextChanged(sender As Object, e As EventArgs) Handles lblNurse.TextChanged
    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim sqlCmd As SqlCommand
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim strSQL As String


    '    strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
    '    strSQL = "Select * from nurse Where NurseID= '" & lblNurse.Text & "'"
    '    sqlCnn = New SqlConnection(strConnectionString)
    '    Try
    '        sqlCnn.Open()
    '        sqlCmd = New SqlCommand(strSQL, sqlCnn)
    '        adapter.SelectCommand = sqlCmd
    '        adapter.Fill(ds)
    '        intMaxRows = ds.Tables(0).Rows.Count

    '        For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
    '            lblNurse.Text = ds.Tables(0).Rows(intRecCount).Item(1)

    '        Next
    '        adapter.Dispose()
    '        sqlCmd.Dispose()
    '        sqlCnn.Close()

    '    Catch ex As Exception
    '        MsgBox("Can not open connection ! ")
    '    End Try

    'End Sub

    Private Sub pstmsiRegister_Click(sender As Object, e As EventArgs) Handles pstmsiRegister.Click
        tabMenu.SelectedTab = TabPage1
        txtLastName.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtIC.ReadOnly = False
        cmbCs.Enabled = True
        cmbGender.Enabled = True
        txtAge.ReadOnly = False
        txtContactno.ReadOnly = False
        txtHomeAdd.ReadOnly = False
        txtEmail.ReadOnly = False
        txtContactPerson.ReadOnly = False
        txtContactNoP.ReadOnly = False
        txtCategory.Enabled = False
        radAdult.Enabled = True
        radChild.Enabled = True
        radSenior.Enabled = True
        radAdult.Checked = False
        radChild.Checked = True
        radSenior.Checked = False

        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtIC.Text = ""
        cmbCs.Text = ""
        cmbGender.Text = ""
        txtAge.Text = ""
        txtContactno.Text = ""
        txtHomeAdd.Text = ""
        txtEmail.Text = ""
        txtContactPerson.Text = ""
        txtContactNoP.Text = ""
        txtCategory.Text = ""
    End Sub



    Private Sub txtIC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIC.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtContactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtContactNoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNoP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtContactPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactPerson.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        If vld(cmbTransaction, txtPrice, txtNurseID) = False Then
            Exit Sub



        Else
            Try
            strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
            strSQL = "INSERT INTO payment(PaymentID,PaymentDate,PaymentTime,PaymentTransactionType,PaymentPrice,PatientID,NurseID)VALUES('" & lblPaymentID.Text & "','" & lblDate.Text & "','" & lblTime.Text & "','" & cmbTransaction.Text & "','" & txtPrice.Text & "', '" & txtIDSearch.Text & "','" & txtNurseID.Text & "')"
            sqlCnn = New SqlConnection(strConnectionString)
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)


            If sqlCmd.ExecuteNonQuery() Then

                MessageBox.Show("Payment successfull")
            Else
                MessageBox.Show("Fail")
            End If
            sqlCmd.Dispose()
            sqlCnn.Close()
        Catch ex As Exception
            MsgBox("Can not open connection !!")
        End Try
        autogeneratid()
        lblPaymentID.Text = ""
        lblName.Text = ""
        lblAddress.Text = ""
        cmbTransaction.Text = ""
        lblAge.Text = ""
        lblContactNo.Text = ""
        txtPrice.Text = ""
        txtNurseID.Text = ""
            txtIDSearch.Text = ""
        End If
    End Sub

    Private Sub autogeneratid()

        Dim sqlCnn As New SqlConnection
        Dim sqlCmd As New SqlCommand




        sqlCnn.ConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        sqlCmd.Connection = sqlCnn
        sqlCnn.Open()

        Dim number As Integer
        sqlCmd.CommandText = "Select Max(PatientID) FROM patient1"

        If IsDBNull(sqlCmd.ExecuteScalar) Then
            number = 1
            lblID.Text = number
        Else
            number = sqlCmd.ExecuteScalar + 1
            lblID.Text = number
        End If
        sqlCmd.Dispose()
        sqlCnn.Close()
        sqlCnn.Dispose()



    End Sub
    Private Sub autogeneratePaymentid()

        Dim sqlCnn As New SqlConnection
        Dim sqlCmd As New SqlCommand




        sqlCnn.ConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        sqlCmd.Connection = sqlCnn
        sqlCnn.Open()

        Dim number As Integer
        sqlCmd.CommandText = "Select Max(PaymentID) FROM payment"

        If IsDBNull(sqlCmd.ExecuteScalar) Then
            number = 1
            lblPaymentID.Text = number
        Else
            number = sqlCmd.ExecuteScalar + 1
            lblPaymentID.Text = number
        End If
        sqlCmd.Dispose()
        sqlCnn.Close()
        sqlCnn.Dispose()



    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        lvImage.Clear()
        lblReportID.Text = ""
        lblDateTime.Text = ""
        lblDiagnosis.Text = ""
        txtComplaints.Text = ""
        lblWeight.Text = ""
        lblHeight.Text = ""
        lblTemperature.Text = ""
        lblBp.Text = ""
        txtMedicine.Text = ""
        txtLab.Text = ""
        txtTreatment.Text = ""
        txtRemarks.Text = ""
        lblNurse.Text = ""
        lblDoctor.Text = ""
    End Sub

    Private Sub txtDoctorID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDoctorID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIDSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDSearch.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtNurseID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNurseID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub pstmsiRecord_Click(sender As Object, e As EventArgs) Handles pstmsiRecord.Click
        tabMenu.SelectedTab = TabPage3
    End Sub

    Private Sub pstmsiSchedule_Click(sender As Object, e As EventArgs) Handles pstmsiSchedule.Click
        tabMenu.SelectedTab = TabPage4
    End Sub

    Private Sub btnMedical_Click(sender As Object, e As EventArgs) Handles btnMedical.Click
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        Dim print As New Print


        print.lblDate.Text = datetext
        print.lblDoctor.Text = lblDoctor.Text
        print.lblDiagnosis.Text = lblDiagnosis.Text

        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from patient1 Where PatientID= '" & txtIDSearch.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)
            intMaxRows = ds.Tables(0).Rows.Count

            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                print.lblFirstname.Text = ds.Tables(0).Rows(intRecCount).Item(2)
                print.lblLastname.Text = ds.Tables(0).Rows(intRecCount).Item(1)
                print.lblAddress.Text = ds.Tables(0).Rows(intRecCount).Item(8)
                print.lblIC.Text = ds.Tables(0).Rows(intRecCount).Item(3)
                print.lblGender.Text = ds.Tables(0).Rows(intRecCount).Item(5)
                print.lblCivilStatus.Text = ds.Tables(0).Rows(intRecCount).Item(4)
                print.lblContactNo.Text = ds.Tables(0).Rows(intRecCount).Item(7)
                print.lblPersonContact.Text = ds.Tables(0).Rows(intRecCount).Item(11)

            Next
            adapter.Dispose()
            sqlCmd.Dispose()
            sqlCnn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        print.Show()
    End Sub

   
Private Sub tsbtnRegister_Click_1(sender As Object, e As EventArgs) Handles tsbtnRegister.Click

        tabMenu.SelectedTab = TabPage1
        txtLastName.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtIC.ReadOnly = False
        cmbCs.Enabled = True
        cmbGender.Enabled = True
        txtAge.ReadOnly = False
        txtContactno.ReadOnly = False
        txtHomeAdd.ReadOnly = False
        txtEmail.ReadOnly = False
        txtContactPerson.ReadOnly = False
        txtContactNoP.ReadOnly = False
        txtCategory.Enabled = False
        radAdult.Enabled = True
        radChild.Enabled = True
        radSenior.Enabled = True
        radAdult.Checked = False
        radChild.Checked = True
        radSenior.Checked = False

        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtIC.Text = ""
        cmbCs.Text = ""
        cmbGender.Text = ""
        txtAge.Text = ""
        txtContactno.Text = ""
        txtHomeAdd.Text = ""
        txtEmail.Text = ""
        txtContactPerson.Text = ""
        txtContactNoP.Text = ""
        txtCategory.Text = ""
    End Sub

    Private Sub pstmsiPrint_Click(sender As Object, e As EventArgs) Handles pstmsiPrint.Click

        If tabMenu.SelectedTab Is TabPage3 Then
            Print.Show()

        ElseIf tabMenu.SelectedTab Is TabPage5 Then
            Me.printReceipt.PrintAction = Printing.PrintAction.PrintToPreview
            Me.printReceipt.Print()
        End If
    End Sub

    Private Sub timerText_Tick(sender As Object, e As EventArgs) Handles timerText.Tick
        lblDataTime.Text = Date.Now.ToString("dd-MM-yyyy   hh:mm:ss")
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub




End Class
