Imports Mocrosoft.Office.InfoPath
Imports System
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.XPath

Namespace OSDTT
	Public Class FromCode
    Private Sub InternalStartup(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Startup
		AddHandler DirectCast(EventManager.ControlEvents("CTRL1_5"), ButtonEvent).Clicked, AddressOf CTRL1_5_Clicked
    End Sub

    Public Sub CTRL1_5_Clicked(ByVal sender As Object, ByVal e As ClickedEventArgs)
		MessageBox.Show("Toggle_TouchScreen")
    End Sub
   End Class
End Namespace