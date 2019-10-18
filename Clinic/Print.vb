
Public Class Print
    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub lblPrint_Click(sender As Object, e As EventArgs) Handles lblPrint.Click
        FormBorderStyle = FormBorderStyle.None
        For Each ctl As Control In Me.Controls
            Me.ActiveControl.Controls.Owner.Visible = False

        Next ctl

        If MessageBox.Show("Do you want to print the medical certificate ? ", "Message", MessageBoxButtons.YesNoCancel
                            ) = Windows.Forms.DialogResult.Yes Then
            Me.printMC.PrintAction = Printing.PrintAction.PrintToPreview
            Me.printMC.Print()

        End If
        ' then make for.ex tetxtbox1.text visible


        Me.Close()
    End Sub
End Class