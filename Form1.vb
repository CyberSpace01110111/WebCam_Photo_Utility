Public Class Form1
    Private _currentPhoto As String
    Private _SelectedCamera As Integer
    Public Property SelectedCamera As Integer
        Get
            Return _SelectedCamera
        End Get
        Set(value As Integer)
            _SelectedCamera = value
        End Set
    End Property
    Public Property CurrentPhoto As String
        Get
            Return _currentPhoto
        End Get
        Set(value As String)
            _currentPhoto = value
        End Set
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'vg1.SetLicenseString("18531899108803084-cybertek")
        SetLicenseString(vg1)
        LoadCamSizes(vg1, cboSize)
        LoadCameraList(vg1, cboVideoDevices)
        vg1.StartPreview()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
    Private Sub LoadCameraList(ByVal ax As VidGrab.VideoGrabber, ByVal cbo As ToolStripComboBox)
        ''Private Sub LoadCameraList(ByVal ax As AxVidgrab_NET.AxVideoGrabberNET, ByVal cbo As ToolStripComboBox)
        cbo.Items.Clear()

        Dim strCameraList As String = ax.GetVideoDevices
        Dim strCamArray As String() = strCameraList.Split(vbCrLf)
        Dim I As Integer
        For I = 0 To strCamArray.Length - 1
            cbo.Items.Add(strCamArray(I))

        Next
        cbo.SelectedIndex = SelectedCamera
    End Sub
    Private Sub SetLicenseString(ByVal ax As VidGrab.VideoGrabber)
        ''Private Sub SetLicenseString(ByVal ax As AxVidgrab_NET.AxVideoGrabberNET)
        ax.LicenseString = "18531899108803084-cybertek"
    End Sub

    Private Function LoadCameraList(ByVal ax As VidGrab.VideoGrabber) As String
        ''Private Function LoadCameraList(ByVal ax As AxVidgrab_NET.AxVideoGrabberNET) As String
        LoadCameraList = ax.GetVideoDevices
    End Function
    Private Sub LoadCamSizes(ByVal ax As VidGrab.VideoGrabber, ByVal cbo As ToolStripComboBox)
        ''Private Sub LoadCamSizes(ByVal ax As AxVidgrab_NET.AxVideoGrabberNET, ByVal cbo As ToolStripComboBox)
        cbo.Items.Clear()

        Dim strSizes As String = ax.GetVideoSizes
        Dim I As Integer
        Dim strSizeArray As String() = strSizes.Split(vbCrLf)
        For I = 0 To strSizeArray.Length - 1
            cbo.Items.Add(strSizeArray(I))

        Next

    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs)
        vg1.StartPreview()

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        CurrentPhoto = GenImageFileName()
        vg1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, CurrentPhoto())
        pb1.Image = System.Drawing.Image.FromFile(CurrentPhoto)
        pb1.BringToFront()
        Call btnSave_Click(sender, e)

    End Sub

    Private Function GenImageFileName() As String
        'Throw New NotImplementedException()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.ImageFolder) = False Then
            My.Computer.FileSystem.CreateDirectory(My.Settings.ImageFolder)
        Else

        End If
        Dim strFileName As String = My.Settings.ImageFolder.ToString
        'Dim files As ReadOnlyCollection(Of String)
        Dim files As Integer
        files = My.Computer.FileSystem.GetFiles(My.Settings.ImageFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.*").Count
        strFileName = String.Format("{0}\IMG-{1}.jpg", My.Settings.ImageFolder, files.ToString)
        GenImageFileName = strFileName


    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        pb1.Image = Nothing
        pb1.Dispose()
        Me.Close()

    End Sub
    Private Sub frmTakePhoto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        vg1.Stop()
        vg1.Dispose()
        e.Cancel = False

    End Sub
    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        pb1.Image = Nothing
        CurrentPhoto = Nothing
        pb1.SendToBack()


    End Sub

    Private Sub cboVideoDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVideoDevices.SelectedIndexChanged
        vg1.StopPreview()
        With vg1
            .StopPreview()
            .VideoDevice = cboVideoDevices.SelectedIndex
            .StartPreview()
            LoadCamSizes(vg1, cboSize)

        End With
    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        With vg1
            .StopPreview()
            .VideoSize = cboSize.SelectedIndex
            .StartPreview()

        End With
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim settings As New frmSettings
        With settings
            .Show()

        End With
    End Sub
End Class
