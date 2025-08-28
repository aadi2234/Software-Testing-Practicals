Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text


        Dim isValidUsername As Boolean = System.Text.RegularExpressions.Regex.IsMatch(username, "^[A-Za-z0-9]{6,}$")


        Dim isValidPassword As Boolean = System.Text.RegularExpressions.Regex.IsMatch(password, "^[A-Za-z0-9!@#$%^&*()_+]{8,}$")

        If username = "" And password = "" Then
            MessageBox.Show("Username and Password Empty.., Enter Username and Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf username = "" Then
        MessageBox.Show("Username Empty.., Enter Username...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf password = "" Then
            MessageBox.Show("Password Empty.., Enter Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf isValidUsername And isValidPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not isValidUsername Then
            MessageBox.Show("Invalid username. Username must be 6+ characters and can only contain A-Z, a-z, and 0-9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not isValidPassword Then
            MessageBox.Show("Invalid password. Password must be 8+ characters and can contain A-Z, a-z, 0-9, and special characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub
End Class
