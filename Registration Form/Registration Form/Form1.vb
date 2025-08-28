Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Enter Username")
            ErrorProvider1.SetError(TextBox1, "Please Enter Username")
        Else
            MsgBox("Valid Username")
            ErrorProvider1.SetError(TextBox1, "")
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please Enter Password")
            ErrorProvider1.SetError(TextBox2, "Please Enter Password")
        Else
            MsgBox("Valid Password")
            ErrorProvider1.SetError(TextBox2, "")
        End If
        If TextBox1.Text & TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Valid Details")
            ErrorProvider1.SetError(TextBox2, "Please Enter Valid Details")
            MsgBox("Please Enter Username & Password")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
