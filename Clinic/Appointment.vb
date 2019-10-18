Imports System.Data
Imports System.Data.SqlClient
Public Class Appointment
    Dim intMaxRows As Integer
    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        If vld(txtDoctorID, cmbTimeStart, txtTimeStart, txtTimeEnd, cmbTimeEnd, txtPatientID, txtNurseID) = False Then
            Exit Sub



        Else

            strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
            strSQL = "INSERT INTO schedule(ScheduleID,ScheduleDate,ScheduleTimeStart,ScheduleTimeEnd,DoctorID,PatientID,NurseID)VALUES('" & lblScheduleID.Text & "','" & dtPicker.Text & "','" & txtTimeStart.Text & " " & cmbTimeStart.Text & "','" & txtTimeEnd.Text & " " & cmbTimeEnd.Text & "','" & txtDoctorID.Text & "','" & txtPatientID.Text & "','" & txtNurseID.Text & "')"
            sqlCnn = New SqlConnection(strConnectionString)
            Try
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)


                If sqlCmd.ExecuteNonQuery() Then

                    MessageBox.Show("Add appointment successfull")
                Else
                    MessageBox.Show("Fail")
                End If
                sqlCmd.Dispose()
                sqlCnn.Close()
            Catch ex As Exception
                MsgBox("Can not open connection !!")
            End Try

        End If
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String


        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from patient1 Where PatientID= '" & txtPatientID.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)
            intMaxRows = ds.Tables(0).Rows.Count

            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                txtPatientID.Text = ds.Tables(0).Rows(intRecCount).Item(0)
                lblPatientName.Text = ds.Tables(0).Rows(intRecCount).Item(1) & "" & ds.Tables(0).Rows(intRecCount).Item(2)
            Next
            adapter.Dispose()
            sqlCmd.Dispose()
            sqlCnn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub


    Private Sub txtDoctorID_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorID.TextChanged

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String


        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from doctor Where DoctorID= '" & txtDoctorID.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlCnn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)
            intMaxRows = ds.Tables(0).Rows.Count

            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1

                txtDoctorName.Text = ds.Tables(0).Rows(intRecCount).Item(1)
            Next
            adapter.Dispose()
            sqlCmd.Dispose()
            sqlCnn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub autogenerateAppointmentid()

        Dim sqlCnn As New SqlConnection
        Dim sqlCmd As New SqlCommand




        sqlCnn.ConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        sqlCmd.Connection = sqlCnn
        sqlCnn.Open()

        Dim number As Integer
        sqlCmd.CommandText = "Select Max(ScheduleID) FROM schedule"

        If IsDBNull(sqlCmd.ExecuteScalar) Then
            number = 1
            lblScheduleID.Text = number
        Else
            number = sqlCmd.ExecuteScalar + 1
            lblScheduleID.Text = number
        End If
        sqlCmd.Dispose()
        sqlCnn.Close()
        sqlCnn.Dispose()



    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogenerateAppointmentid()
    End Sub

    Private Sub txtDoctorID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDoctorID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtTimeStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTimeStart.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtTimeEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTimeEnd.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPatientID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPatientID.KeyPress
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
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)

            If ctl(i).text = "" Then
                epText.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
End Class