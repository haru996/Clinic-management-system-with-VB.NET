Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Dim intMaxRows As Integer
    Dim intRec As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogeneratRecordid()

    End Sub
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String
        Dim strBP As String = txtBP.Text
        If vld(txtComplaints, txtWeight, txtHeight, txtTemperature, txtBP, txtDiagnosis, txtMedicine, txtTreatment, txtLaboratory, txtRemarks, txtDoctorID, txtNurseID) = False Then
            Exit Sub
        Else

            strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
            strSQL = "INSERT INTO record(RecordID,RecordDate,RecordTime,RecordComplaints,RecordWeight,RecordHeight,RecordTemperature,RecordBP,RecordDiagnosis,RecordMedicine,RecordTreatment,RecordLaboratory,RecordRemarks,PatientID,NurseID,DoctorID)VALUES('" & lblRecordID.Text & "','" & txtDate.Text & "','" & txtTime.Text & "','" & txtComplaints.Text & "','" & txtWeight.Text & "','" & txtHeight.Text & "','" & txtTemperature.Text & "','" & strBP & "','" & txtDiagnosis.Text & "','" & txtMedicine.Text & "','" & txtTreatment.Text & "','" & txtLaboratory.Text & "','" & txtRemarks.Text & "','" & lblRecPatientID.Text & "','" & txtNurseID.Text & "','" & txtDoctorID.Text & "')"
            sqlCnn = New SqlConnection(strConnectionString)
            Try
                sqlCnn.Open()
                sqlCmd = New SqlCommand(strSQL, sqlCnn)


                If sqlCmd.ExecuteNonQuery() Then

                    MessageBox.Show("Add Record successfull")
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtDoctor_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorID.TextChanged

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String


        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from doctor Where DoctorID= '" & txtDoctorID.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        sqlCmd = New SqlCommand(strSQL, sqlCnn)
        adapter.SelectCommand = sqlCmd
        adapter.Fill(ds)
        intMaxRows = ds.Tables(0).Rows.Count
        For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
            txtDoctor.Text = ds.Tables(0).Rows(intRecCount).Item(1)
        Next
        adapter.Dispose()
        sqlCmd.Dispose()
        sqlCnn.Close()


    End Sub

    Private Sub txtNurse_TextChanged(sender As Object, e As EventArgs) Handles txtNurseID.TextChanged

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSQL As String


        strConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        strSQL = "Select * from nurse Where NurseID= '" & txtNurseID.Text & "'"
        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        sqlCmd = New SqlCommand(strSQL, sqlCnn)
        adapter.SelectCommand = sqlCmd
        adapter.Fill(ds)
        intMaxRows = ds.Tables(0).Rows.Count
        For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
            txtNurse.Text = ds.Tables(0).Rows(intRecCount).Item(1)
        Next
        adapter.Dispose()
        sqlCmd.Dispose()
        sqlCnn.Close()


    End Sub


    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtTemperature_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTemperature.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtBP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub autogeneratRecordid()

        Dim sqlCnn As New SqlConnection
        Dim sqlCmd As New SqlCommand




        sqlCnn.ConnectionString = "Data Source=DESKTOP-CNER6KA;Initial Catalog=hospital;Integrated Security=True"
        sqlCmd.Connection = sqlCnn
        sqlCnn.Open()

        Dim number As Integer
        sqlCmd.CommandText = "Select Max(RecordID) FROM record"

        If IsDBNull(sqlCmd.ExecuteScalar) Then
            number = 1
            lblRecordID.Text = number
        Else
            number = sqlCmd.ExecuteScalar + 1
            lblRecordID.Text = number
        End If
        sqlCmd.Dispose()
        sqlCnn.Close()
        sqlCnn.Dispose()



    End Sub


End Class