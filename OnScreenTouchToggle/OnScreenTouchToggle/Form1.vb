Public Class Form1
    Private Sub Button3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub Button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TopMost = Not Me.TopMost
    End Sub
    Private Sub Button2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("TouchToggle.bat")
    End Sub

End Class
