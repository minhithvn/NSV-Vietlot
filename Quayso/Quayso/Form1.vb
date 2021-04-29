Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randomGen As New Random()
        Dim num As Integer
        num = randomGen.Next(1, 250)
        TextBox1.Text = num.ToString



    End Sub
End Class
