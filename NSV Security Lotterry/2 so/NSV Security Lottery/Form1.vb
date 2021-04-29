
Public Class Form1


    Private Function a() As Boolean
        ' Get our process name.
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName

        ' Get information about processes with this name.
        Dim procs() As Process =
        Process.GetProcessesByName(my_name)

        ' If there is only one, it's us.
        If procs.Length = 1 Then Return False

        ' If there is more than one process,
        ' see if one has a StartTime before ours.
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
            Return True
        Next i

        ' If we get here, we were first.
        Return False
    End Function

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("..\Spin\1.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile1()
        My.Computer.Audio.Play("..\Spin\2.wav")
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.BackColor = Color.FromKnownColor(KnownColor.Window)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If a() Then
            MessageBox.Show(
                "Ứng dụng đã được bật",
                "Ứng dụng đang chạy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Me.Close()
        End If
        PlayBackgroundSoundFile1()
        Timer1.Stop()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = CStr(Int(Rnd() * 4))
        Label2.Text = CStr(Int(Rnd() * 9))


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
        PlayBackgroundSoundFile()
        Label4.Text = ""
        Cursor.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        'Timer1.Stop()
        'StopBackgroundSound()
        'Label4.Text = "Lucky number is : " & Label1.Text & Label2.Text
        'PlayBackgroundSoundFile1()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        StopBackgroundSound()
        Label4.Text = "Lucky number is : " & Label1.Text & Label2.Text
        PlayBackgroundSoundFile1()
        Cursor.Show()
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Call Button1_Click_1()
            e.Handled = True

        End If

    End Sub
    Private Sub Button1_Click_1()
        Throw New NotImplementedException()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click()
        Throw New NotImplementedException()
    End Sub


End Class
