Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim number1 As String() = New String() {TextBox1.Text}
        Dim number1 As Integer() = {7, 19, 20, 23, 36, 55, 92, 3, 31, 45, 46, 49, 54, 40, 5, 11, 17, 20, 26, 37, 12, 19, 20, 20, 29, 36, 39, 22, 9, 13, 17, 33, 34, 53, 31, 16, 18, 20, 25, 35, 36, 17, 17, 24, 38, 41, 46, 54, 51}
        Dim number2 As Integer() = {19, 20, 20, 29, 36, 39, 22}
        Dim number3 As Integer() = {9, 13, 17, 33, 34, 53, 31}
        Dim number4 As Integer() = {16, 18, 20, 25, 35, 36, 17}
        Dim number5 As Integer() = {17, 24, 38, 41, 46, 54, 51}
        Dim number6 As Integer() = {3, 31, 45, 46, 49, 54, 40}
        Dim number7 As Integer() = {7, 19, 20, 23, 36, 55, 92}
        'Dim counts = From n In number1 Group n By n Into Group
        '             Select so = n, dem = Group.Count()
        '             Order By dem Descending
        'For Each c In counts
        '    TextBox8.Text = (c.so + c.dem)

        'Next
        Dim mode = number1.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox8.Text = mode
        Dim mode1 = number2.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox9.Text = mode1
        Dim mode2 = number3.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox10.Text = mode2
        Dim mode3 = number4.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox11.Text = mode3
        Dim mode4 = number5.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox12.Text = mode4
        Dim mode5 = number6.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox13.Text = mode5
        Dim mode6 = number7.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        TextBox14.Text = mode6
        'Dim mode7 = number1.GroupBy(Function(n) n).OrderByDescending(Function(g) g.Count).Select(Function(g) g.Key).FirstOrDefault
        'TextBox15.Text = mode7



    End Sub
End Class
