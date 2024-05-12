Public Class devibrahimcelik

    'Reedited & updated for 64 bit by software developer IBRAHIM CELIK
    'YouTube: @devibrahimcelik | : https://www.youtube.com/@devibrahimcelik
    'Github: https://github.com/SoftwareDEVibrahimcelik
    'Instagram: softwaredevic
    'Donate Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk


    Private Sub devibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        WriteDMAInteger("GTA5", Label1.Text + &H29BD898, {&H38, &H18, &H10, &H8, &H1668, &H1538, &H970}, 1000000, 7)
        WriteDMAInteger("GTA5", Label1.Text + &H29BD898, {&H98, &H18, &H18, &H8, &H968, &H108, &H980}, 1000000, 7)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/@devibrahimcelik")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://discord.com/invite/HBBkbneJ49")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Clipboard.SetDataObject("3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
        MsgBox("Copied bitcoin address")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim p() As Process
        p = Process.GetProcessesByName("GTA5")


        If p.Count > 0 Then
            Label2.ForeColor = Color.Lime
            Label2.Text = "GTA 5  is working"
        Else
            Label2.Text = "GTA 5  is NOT working"
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim ibrahim_celik53 As Process = Process.GetProcessesByName("GTA5")(0)
        For Each moz As System.Diagnostics.ProcessModule In ibrahim_celik53.Modules
            If moz.FileName.IndexOf("GTA5.exe") <> -1 Then
                Label1.Text = moz.BaseAddress.ToString
            End If
        Next

        Timer2.Interval = 10000 ''10 Saniye sonrasında base adresi alıcak. Yani bu bir looptur.
    End Sub
End Class