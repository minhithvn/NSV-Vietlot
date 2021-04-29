
Public Class Form1
    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("..\Debug\1.wav")
    End Sub
    Sub PlayBackgroundSoundFile1()
        My.Computer.Audio.Play("..\Debug\2.wav")
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayBackgroundSoundFile1()
        Timer1.Stop()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = CStr(Int(Rnd() * 3))
        Label2.Text = CStr(Int(Rnd() * 9))
        Label3.Text = CStr(Int(Rnd() * 9))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        PlayBackgroundSoundFile()
        Label4.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        StopBackgroundSound()
        Label4.Text = "Lucky number is : " & Label1.Text & Label2.Text & Label3.Text
        PlayBackgroundSoundFile1()
    End Sub
End Class
