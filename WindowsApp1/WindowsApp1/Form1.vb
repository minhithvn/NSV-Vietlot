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

    Sub PlayBackgroundSoundFile1()
        My.Computer.Audio.Play("..\Debug\2.wav")
    End Sub
    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("..\Debug\1.wav")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If a() Then
            MessageBox.Show(
                "Chương trình đang được bật rồi em ơi", "Ứng dụng đang chạy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Me.Close()
        End If
        PlayBackgroundSoundFile1()
        Me.WindowState = FormWindowState.Maximized
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayBackgroundSoundFile()
        Timer1.Start()
        Label9.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim number2 As Array = {20025, 20027, 20034, 20046, 20047, 20044, 20033, 20012, 20045,
         20031, 30024, 30033, 30026, 50053, 50038, 50052, 50049, 50051, 50047, 50054, 50055,
         50056, 50057, 60054, 60057, 60038, 60055, 60026, 60025, 10242, 60032, 60058, 70025,
         70105, 70095, 70036, 70044, 70074, 70085, 70092, 70093, 70094, 70100, 70101, 70103,
         40022, 40025, 40009, 40026, 10019, 10042, 10134, 10167, 10179, 10200, 10275, 10423,
         10021, 10007, 10078, 10086, 10089, 10099, 10058, 10168, 10175, 10182, 10190,
         10196, 10209, 10216, 10218, 10237, 10252, 10113, 10114, 10278, 10280, 10296, 10304, 10332,
         10424, 10426, 10440, 10443, 10549, 10550, 10558, 10594, 10701, 10741,
         10811, 10961, 10982, 11009, 11123, 11141, 11292, 11293, 11295, 11298,
         11316, 11435, 11475, 11489, 11500, 11615, 11655, 11671, 11697, 11704, 11705,
         11707, 11724, 11752, 11759, 11787, 11806, 11821, 11840, 11845, 11854, 11864,
         11885, 11894, 11896, 11909, 11915, 11940, 11943, 11947,
         11949, 11963, 11967, 11974, 11983, 11997, 12009, 12016, 12018, 12019, 12026,
         12030, 12038, 12068, 12087, 12096, 12126, 12128, 12169, 12171, 12175, 12179,
         12189, 12220, 12225, 12232, 12234, 12245, 12246, 12247, 12258, 12274, 12277,
         12279, 12280, 12281, 12286, 12288, 12292, 12293, 12299, 12307, 12309, 12311,
         12315, 12320, 12322, 12323, 12324, 12337, 12342, 12343, 12344, 12345, 12353, 12355, 12358,
         12361, 12366, 12368, 12370, 12371, 12373, 12377, 12378, 12379, 12382, 12383, 12384,
         12386, 12391, 12392, 12394, 12396, 12397, 12399, 12402, 12410, 12411, 12412, 12413, 12416, 12418, 12419, 12423, 12426,
        12428, 12429, 12433, 12434, 12435, 12436, 12437, 12438, 12439, 12442, 12443, 12444, 12448,
        12449, 12451, 12452, 12453, 12454, 12456, 12457, 12458, 12459}
        Label1.Text = CInt(Rnd() * 9)
        Label2.Text = CInt(Rnd() * 9)
        Label3.Text = CInt(Rnd() * 9)
        Label4.Text = CInt(Rnd() * 9)
        Label5.Text = CInt(Rnd() * 9)


        For Each y In number2

            Label6.Text = Label1.Text & Label2.Text & Label3.Text & Label4.Text & Label5.Text
            If y = Label6.Text Then
                Timer1.Stop()
                Label9.Text = " Chúc mừng bạn có mã nhân viên là " & Label6.Text & " đã chiến thắng"
                PlayBackgroundSoundFile1()
            End If
        Next


    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PlayBackgroundSoundFile1()
        Timer1.Stop()

    End Sub

End Class
