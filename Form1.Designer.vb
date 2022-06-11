<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.vg1 = New VidGrab.VideoGrabber()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboVideoDevices = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboSize = New System.Windows.Forms.ToolStripComboBox()
        Me.btnCapture = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClearImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vg1
        '
        Me.vg1.AdjustOverlayAspectRatio = True
        Me.vg1.AdjustPixelAspectRatio = True
        Me.vg1.Aero = VidGrab.TAero.ae_Default
        Me.vg1.AnalogVideoStandard = -1
        Me.vg1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default
        Me.vg1.ASFAudioBitRate = -1
        Me.vg1.ASFAudioChannels = -1
        Me.vg1.ASFBufferWindow = -1
        Me.vg1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced
        Me.vg1.ASFFixedFrameRate = True
        Me.vg1.ASFMediaServerPublishingPoint = ""
        Me.vg1.ASFMediaServerRemovePublishingPointAfterDisconnect = False
        Me.vg1.ASFMediaServerTemplatePublishingPoint = ""
        Me.vg1.ASFNetworkMaxUsers = 5
        Me.vg1.ASFNetworkPort = 0
        Me.vg1.ASFProfile = -1
        Me.vg1.ASFProfileFromCustomFile = ""
        Me.vg1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8
        Me.vg1.ASFVideoBitRate = -1
        Me.vg1.ASFVideoFrameRate = 0R
        Me.vg1.ASFVideoHeight = -1
        Me.vg1.ASFVideoMaxKeyFrameSpacing = -1
        Me.vg1.ASFVideoQuality = 80
        Me.vg1.ASFVideoWidth = -1
        Me.vg1.AspectRatioToUse = -1.0R
        Me.vg1.AssociateAudioAndVideoDevices = False
        Me.vg1.AudioBalance = 0
        Me.vg1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_Normal
        Me.vg1.AudioCompressor = 0
        Me.vg1.AudioDevice = -1
        Me.vg1.AudioDeviceRendering = False
        Me.vg1.AudioFormat = VidGrab.TAudioFormat.af_default
        Me.vg1.AudioInput = -1
        Me.vg1.AudioInputBalance = 0
        Me.vg1.AudioInputLevel = 65535
        Me.vg1.AudioInputMono = False
        Me.vg1.AudioPeakEvent = False
        Me.vg1.AudioRecording = False
        Me.vg1.AudioRenderer = -1
        Me.vg1.AudioSource = VidGrab.TAudioSource.as_Default
        Me.vg1.AudioStreamNumber = -1
        Me.vg1.AudioSyncAdjustment = 0
        Me.vg1.AudioSyncAdjustmentEnabled = False
        Me.vg1.AudioVolume = 32767
        Me.vg1.AutoConnectRelatedPins = True
        Me.vg1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential
        Me.vg1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz"
        Me.vg1.AutoFileNameMinDigits = 6
        Me.vg1.AutoFilePrefix = "vg"
        Me.vg1.AutoRefreshPreview = False
        Me.vg1.AutoStartPlayer = True
        Me.vg1.AVIDurationUpdated = True
        Me.vg1.AVIFormatOpenDML = True
        Me.vg1.AVIFormatOpenDMLCompatibilityIndex = True
        Me.vg1.BackColor = System.Drawing.Color.DarkGray
        Me.vg1.BackgroundColor = 0
        Me.vg1.BufferCount = -1
        Me.vg1.BurstCount = 3
        Me.vg1.BurstInterval = 0
        Me.vg1.BurstMode = False
        Me.vg1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap
        Me.vg1.BusyCursor = VidGrab.TCursors.cr_HourGlass
        Me.vg1.CameraControlSettings = True
        Me.vg1.CaptureFileExt = ""
        Me.vg1.ColorKey = 1048592
        Me.vg1.ColorKeyEnabled = False
        Me.vg1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        Me.vg1.CompressionType = VidGrab.TCompressionType.ct_Video
        Me.vg1.Cropping_Enabled = False
        Me.vg1.Cropping_Height = 120
        Me.vg1.Cropping_Outbounds = True
        Me.vg1.Cropping_Width = 160
        Me.vg1.Cropping_X = 0
        Me.vg1.Cropping_Y = 0
        Me.vg1.Cropping_Zoom = 1.0R
        Me.vg1.Display_Active = True
        Me.vg1.Display_AlphaBlendEnabled = False
        Me.vg1.Display_AlphaBlendValue = 180
        Me.vg1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.vg1.Display_AutoSize = False
        Me.vg1.Display_Embedded = True
        Me.vg1.Display_FullScreen = False
        Me.vg1.Display_Height = 240
        Me.vg1.Display_Left = 10
        Me.vg1.Display_Monitor = 0
        Me.vg1.Display_MouseMovesWindow = True
        Me.vg1.Display_PanScanRatio = 50
        Me.vg1.Display_StayOnTop = False
        Me.vg1.Display_Top = 10
        Me.vg1.Display_TransparentColorEnabled = False
        Me.vg1.Display_TransparentColorValue = 255
        Me.vg1.Display_VideoPortEnabled = True
        Me.vg1.Display_Visible = True
        Me.vg1.Display_Width = 320
        Me.vg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vg1.DoubleBuffered = False
        Me.vg1.DroppedFramesPollingInterval = -1
        Me.vg1.DualDisplay_Active = False
        Me.vg1.DualDisplay_AlphaBlendEnabled = False
        Me.vg1.DualDisplay_AlphaBlendValue = 180
        Me.vg1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.vg1.DualDisplay_AutoSize = False
        Me.vg1.DualDisplay_Embedded = False
        Me.vg1.DualDisplay_FullScreen = False
        Me.vg1.DualDisplay_Height = 240
        Me.vg1.DualDisplay_Left = 20
        Me.vg1.DualDisplay_Monitor = 0
        Me.vg1.DualDisplay_MouseMovesWindow = True
        Me.vg1.DualDisplay_PanScanRatio = 50
        Me.vg1.DualDisplay_StayOnTop = False
        Me.vg1.DualDisplay_Top = 400
        Me.vg1.DualDisplay_TransparentColorEnabled = False
        Me.vg1.DualDisplay_TransparentColorValue = 255
        Me.vg1.DualDisplay_VideoPortEnabled = False
        Me.vg1.DualDisplay_Visible = True
        Me.vg1.DualDisplay_Width = 320
        Me.vg1.DVDateTimeEnabled = True
        Me.vg1.DVDiscontinuityMinimumInterval = 3
        Me.vg1.DVDTitle = 0
        Me.vg1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD
        Me.vg1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full
        Me.vg1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default
        Me.vg1.DVRecordingInNativeFormatSeparatesStreams = False
        Me.vg1.DVReduceFrameRate = False
        Me.vg1.DVRgb219 = False
        Me.vg1.DVTimeCodeEnabled = True
        Me.vg1.EventNotificationSynchrone = True
        Me.vg1.FixFlickerOrBlackCapture = False
        Me.vg1.FrameCaptureHeight = -1
        Me.vg1.FrameCaptureWidth = -1
        Me.vg1.FrameCaptureWithoutOverlay = False
        Me.vg1.FrameCaptureZoomSize = 100
        Me.vg1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams
        Me.vg1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default
        Me.vg1.FrameNumberStartsFromZero = False
        Me.vg1.FrameRate = 0R
        Me.vg1.HoldRecording = False
        Me.vg1.ImageOverlay_AlphaBlend = False
        Me.vg1.ImageOverlay_AlphaBlendValue = 180
        Me.vg1.ImageOverlay_ChromaKey = False
        Me.vg1.ImageOverlay_ChromaKeyLeewayPercent = 25
        Me.vg1.ImageOverlay_ChromaKeyRGBColor = 0
        Me.vg1.ImageOverlay_Height = -1
        Me.vg1.ImageOverlay_LeftLocation = 10
        Me.vg1.ImageOverlay_RotationAngle = 0R
        Me.vg1.ImageOverlay_StretchToVideoSize = False
        Me.vg1.ImageOverlay_TopLocation = 10
        Me.vg1.ImageOverlay_Transparent = False
        Me.vg1.ImageOverlay_TransparentColorValue = 0
        Me.vg1.ImageOverlay_UseTransparentColor = False
        Me.vg1.ImageOverlay_Width = -1
        Me.vg1.ImageOverlayEnabled = False
        Me.vg1.ImageOverlaySelector = 0
        Me.vg1.IPCameraURL = ""
        Me.vg1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality
        Me.vg1.JPEGProgressiveDisplay = False
        Me.vg1.JPEGQuality = 100
        Me.vg1.LicenseString = "N/A"
        Me.vg1.Location = New System.Drawing.Point(0, 0)
        Me.vg1.LogoDisplayed = False
        Me.vg1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
        Me.vg1.MixAudioSamples_CurrentSourceLevel = 100
        Me.vg1.MixAudioSamples_ExternalSourceLevel = 100
        Me.vg1.Mixer_MosaicColumns = 1
        Me.vg1.Mixer_MosaicLines = 1
        Me.vg1.MotionDetector_CompareBlue = True
        Me.vg1.MotionDetector_CompareGreen = True
        Me.vg1.MotionDetector_CompareRed = True
        Me.vg1.MotionDetector_Enabled = False
        Me.vg1.MotionDetector_GreyScale = False
        Me.vg1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" &
    "555555 5555555555 5555555555"
        Me.vg1.MotionDetector_MaxDetectionsPerSecond = 0R
        Me.vg1.MotionDetector_ReduceCPULoad = 1
        Me.vg1.MotionDetector_ReduceVideoNoise = False
        Me.vg1.MotionDetector_Triggered = False
        Me.vg1.MouseWheelEventEnabled = True
        Me.vg1.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default
        Me.vg1.MultiplexedInputEmulation = True
        Me.vg1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed
        Me.vg1.MultiplexedStabilizationDelay = 100
        Me.vg1.MultiplexedSwitchDelay = 0
        Me.vg1.Multiplexer = -1
        Me.vg1.MuteAudioRendering = False
        Me.vg1.Name = "vg1"
        Me.vg1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled
        Me.vg1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming
        Me.vg1.NormalCursor = VidGrab.TCursors.cr_Default
        Me.vg1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread
        Me.vg1.NotificationPriority = VidGrab.TThreadPriority.tpNormal
        Me.vg1.NotificationSleepTime = -1
        Me.vg1.OnFrameBitmapEventSynchrone = False
        Me.vg1.OverlayAfterTransform = False
        Me.vg1.OwnerObject = Nothing
        Me.vg1.PlayerAudioRendering = True
        Me.vg1.PlayerDuration = CType(1, Long)
        Me.vg1.PlayerDVSize = VidGrab.TDVSize.dv_Full
        Me.vg1.PlayerFastSeekSpeedRatio = 4
        Me.vg1.PlayerFileName = ""
        Me.vg1.PlayerForcedCodec = ""
        Me.vg1.PlayerFramePosition = CType(1, Long)
        Me.vg1.PlayerRefreshPausedDisplay = False
        Me.vg1.PlayerRefreshPausedDisplayFrameRate = 0R
        Me.vg1.PlayerSpeedRatio = 1.0R
        Me.vg1.PlayerTimePosition = CType(0, Long)
        Me.vg1.PlayerTrackBarSynchrone = False
        Me.vg1.PlaylistIndex = 0
        Me.vg1.PreallocCapFileCopiedAfterRecording = True
        Me.vg1.PreallocCapFileEnabled = False
        Me.vg1.PreallocCapFileName = ""
        Me.vg1.PreallocCapFileSizeInMB = 100
        Me.vg1.PreviewZoomSize = 100
        Me.vg1.QuickDeviceInitialization = False
        Me.vg1.RawAudioSampleCapture = False
        Me.vg1.RawCaptureAsyncEvent = True
        Me.vg1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat
        Me.vg1.RawVideoSampleCapture = False
        Me.vg1.RecordingAudioBitRate = -1
        Me.vg1.RecordingBacktimedFramesCount = 0
        Me.vg1.RecordingCanPause = False
        Me.vg1.RecordingFileName = ""
        Me.vg1.RecordingInNativeFormat = True
        Me.vg1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        Me.vg1.RecordingOnMotion_Enabled = False
        Me.vg1.RecordingOnMotion_MotionThreshold = 0R
        Me.vg1.RecordingOnMotion_NoMotionPauseDelayMs = 5000
        Me.vg1.RecordingPauseCreatesNewFile = False
        Me.vg1.RecordingSize = VidGrab.TRecordingSize.rs_Default
        Me.vg1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled
        Me.vg1.RecordingTimerInterval = 0
        Me.vg1.RecordingVideoBitRate = -1
        Me.vg1.Reencoding_IncludeAudioStream = True
        Me.vg1.Reencoding_IncludeVideoStream = True
        Me.vg1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF
        Me.vg1.Reencoding_NewVideoClip = ""
        Me.vg1.Reencoding_SourceVideoClip = ""
        Me.vg1.Reencoding_StartFrame = CType(-1, Long)
        Me.vg1.Reencoding_StartTime = CType(-1, Long)
        Me.vg1.Reencoding_StopFrame = CType(-1, Long)
        Me.vg1.Reencoding_StopTime = CType(-1, Long)
        Me.vg1.Reencoding_UseAudioCompressor = False
        Me.vg1.Reencoding_UseFrameGrabber = True
        Me.vg1.Reencoding_UseVideoCompressor = False
        Me.vg1.Reencoding_WMVOutput = False
        Me.vg1.ScreenRecordingLayeredWindows = False
        Me.vg1.ScreenRecordingMonitor = 0
        Me.vg1.ScreenRecordingNonVisibleWindows = False
        Me.vg1.ScreenRecordingThroughClipboard = False
        Me.vg1.ScreenRecordingWithCursor = True
        Me.vg1.SendToDV_DeviceIndex = -1
        Me.vg1.Size = New System.Drawing.Size(800, 450)
        Me.vg1.SpeakerBalance = 0
        Me.vg1.SpeakerControl = False
        Me.vg1.SpeakerVolume = 65535
        Me.vg1.StoragePath = "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"
        Me.vg1.StoreDeviceSettingsInRegistry = True
        Me.vg1.SyncCommands = True
        Me.vg1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master
        Me.vg1.Synchronized = False
        Me.vg1.SyncPreview = VidGrab.TSyncPreview.sp_Auto
        Me.vg1.TabIndex = 0
        Me.vg1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left
        Me.vg1.TextOverlay_BkColor = 16777215
        Me.vg1.TextOverlay_Enabled = False
        'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.vg1.TextOverlay_FontColor = 16776960
        Me.vg1.TextOverlay_Left = 0
        Me.vg1.TextOverlay_Right = -1
        Me.vg1.TextOverlay_Scrolling = False
        Me.vg1.TextOverlay_ScrollingSpeed = 1
        Me.vg1.TextOverlay_Selector = 0
        Me.vg1.TextOverlay_Shadow = True
        Me.vg1.TextOverlay_ShadowColor = 0
        Me.vg1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_NorthWest
        Me.vg1.TextOverlay_String = resources.GetString("vg1.TextOverlay_String")
        Me.vg1.TextOverlay_Top = 0
        Me.vg1.TextOverlay_Transparent = True
        Me.vg1.ThirdPartyDeinterlacer = ""
        Me.vg1.TranslateMouseCoordinates = True
        Me.vg1.TunerFrequency = -1
        Me.vg1.TunerMode = VidGrab.TTunerMode.tm_TVTuner
        Me.vg1.TVChannel = 0
        Me.vg1.TVCountryCode = 0
        Me.vg1.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable
        Me.vg1.TVUseFrequencyOverrides = False
        Me.vg1.UseClock = True
        Me.vg1.VCRHorizontalLocking = False
        Me.vg1.Version = "v8.8.4.1 (build 131004) - Copyright ©2013 Datastead"
        Me.vg1.VideoCompression_DataRate = -1
        Me.vg1.VideoCompression_KeyFrameRate = 15
        Me.vg1.VideoCompression_PFramesPerKeyFrame = 0
        Me.vg1.VideoCompression_Quality = 1.0R
        Me.vg1.VideoCompression_WindowSize = -1
        Me.vg1.VideoCompressor = 0
        Me.vg1.VideoControlSettings = True
        Me.vg1.VideoCursor = VidGrab.TCursors.cr_Default
        Me.vg1.VideoDevice = -1
        Me.vg1.VideoFormat = -1
        Me.vg1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc
        Me.vg1.VideoFromImages_RepeatIndefinitely = False
        Me.vg1.VideoFromImages_SourceDirectory = "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"
        Me.vg1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat"
        Me.vg1.VideoInput = -1
        Me.vg1.VideoProcessing_Brightness = 0
        Me.vg1.VideoProcessing_Contrast = 0
        Me.vg1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled
        Me.vg1.VideoProcessing_FlipHorizontal = False
        Me.vg1.VideoProcessing_FlipVertical = False
        Me.vg1.VideoProcessing_GrayScale = False
        Me.vg1.VideoProcessing_Hue = 0
        Me.vg1.VideoProcessing_InvertColors = False
        Me.vg1.VideoProcessing_Pixellization = 1
        Me.vg1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg
        Me.vg1.VideoProcessing_RotationCustomAngle = 45.5R
        Me.vg1.VideoProcessing_Saturation = 0
        Me.vg1.VideoQualitySettings = True
        Me.vg1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect
        Me.vg1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        Me.vg1.VideoRendererExternalIndex = -1
        Me.vg1.VideoSize = -1
        Me.vg1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice
        Me.vg1.VideoSource_FileOrURL = ""
        Me.vg1.VideoSource_FileOrURL_StartTime = CType(-1, Long)
        Me.vg1.VideoSource_FileOrURL_StopTime = CType(-1, Long)
        Me.vg1.VideoSubtype = -1
        Me.vg1.VideoVisibleWhenStopped = False
        Me.vg1.VirtualAudioStreamControl = -1
        Me.vg1.VirtualVideoStreamControl = -1
        Me.vg1.VuMeter = VidGrab.TVuMeter.vu_Disabled
        Me.vg1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled
        Me.vg1.ZoomCoeff = 1000
        Me.vg1.ZoomXCenter = 0
        Me.vg1.ZoomYCenter = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboVideoDevices, Me.ToolStripLabel2, Me.cboSize, Me.btnCapture, Me.btnSave, Me.btnClearImage, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel1.Text = "Select Camera"
        '
        'cboVideoDevices
        '
        Me.cboVideoDevices.Name = "cboVideoDevices"
        Me.cboVideoDevices.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel2.Text = "Select Resolution"
        '
        'cboSize
        '
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 25)
        '
        'btnCapture
        '
        Me.btnCapture.Image = Global.WebCam_Photo_Utility.My.Resources.Resources.Camera
        Me.btnCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(104, 22)
        Me.btnCapture.Text = "Capture Photo"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = Global.WebCam_Photo_Utility.My.Resources.Resources.Save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnClearImage
        '
        Me.btnClearImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClearImage.Image = Global.WebCam_Photo_Utility.My.Resources.Resources.Clear
        Me.btnClearImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClearImage.Name = "btnClearImage"
        Me.btnClearImage.Size = New System.Drawing.Size(23, 22)
        Me.btnClearImage.Text = "Clear"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WebCam_Photo_Utility.My.Resources.Resources.Settings
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton2.Text = "Settings..."
        '
        'pb1
        '
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(800, 450)
        Me.pb1.TabIndex = 2
        Me.pb1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.vg1)
        Me.Controls.Add(Me.pb1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Webcam Photo Utility"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vg1 As VidGrab.VideoGrabber
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cboVideoDevices As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cboSize As ToolStripComboBox
    Friend WithEvents btnCapture As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnClearImage As ToolStripButton
End Class
