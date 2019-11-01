<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Postto = New System.Windows.Forms.ComboBox()
        Me.URLtxt = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.station = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Buckettxt = New System.Windows.Forms.ComboBox()
        Me.agvidtxt = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Sendpost = New System.Windows.Forms.Button()
        Me.endpointtxt = New System.Windows.Forms.MaskedTextBox()
        Me.Jobpriortxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Workfaceselect = New System.Windows.Forms.ComboBox()
        Me.Robojobtxt = New System.Windows.Forms.MaskedTextBox()
        Me.LetDownFlagselect = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RoboJobID = New System.Windows.Forms.Label()
        Me.WarehouseIDtxt = New System.Windows.Forms.MaskedTextBox()
        Me.BucketID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ytxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WorkFace = New System.Windows.Forms.Label()
        Me.Xtxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'Postto
        '
        Me.Postto.FormattingEnabled = True
        Me.Postto.Items.AddRange(New Object() {resources.GetString("Postto.Items"), resources.GetString("Postto.Items1"), resources.GetString("Postto.Items2"), resources.GetString("Postto.Items3")})
        resources.ApplyResources(Me.Postto, "Postto")
        Me.Postto.Name = "Postto"
        '
        'URLtxt
        '
        resources.ApplyResources(Me.URLtxt, "URLtxt")
        Me.URLtxt.Name = "URLtxt"
        Me.URLtxt.ReadOnly = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.station)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Buckettxt)
        Me.GroupBox1.Controls.Add(Me.agvidtxt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Sendpost)
        Me.GroupBox1.Controls.Add(Me.URLtxt)
        Me.GroupBox1.Controls.Add(Me.endpointtxt)
        Me.GroupBox1.Controls.Add(Me.Postto)
        Me.GroupBox1.Controls.Add(Me.Jobpriortxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Workfaceselect)
        Me.GroupBox1.Controls.Add(Me.Robojobtxt)
        Me.GroupBox1.Controls.Add(Me.LetDownFlagselect)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.RoboJobID)
        Me.GroupBox1.Controls.Add(Me.WarehouseIDtxt)
        Me.GroupBox1.Controls.Add(Me.BucketID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Ytxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.WorkFace)
        Me.GroupBox1.Controls.Add(Me.Xtxt)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'station
        '
        Me.station.FormattingEnabled = True
        Me.station.Items.AddRange(New Object() {resources.GetString("station.Items"), resources.GetString("station.Items1")})
        resources.ApplyResources(Me.station, "station")
        Me.station.Name = "station"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Buckettxt
        '
        Me.Buckettxt.FormattingEnabled = True
        Me.Buckettxt.Items.AddRange(New Object() {resources.GetString("Buckettxt.Items"), resources.GetString("Buckettxt.Items1"), resources.GetString("Buckettxt.Items2"), resources.GetString("Buckettxt.Items3"), resources.GetString("Buckettxt.Items4"), resources.GetString("Buckettxt.Items5"), resources.GetString("Buckettxt.Items6"), resources.GetString("Buckettxt.Items7"), resources.GetString("Buckettxt.Items8"), resources.GetString("Buckettxt.Items9"), resources.GetString("Buckettxt.Items10"), resources.GetString("Buckettxt.Items11"), resources.GetString("Buckettxt.Items12"), resources.GetString("Buckettxt.Items13"), resources.GetString("Buckettxt.Items14"), resources.GetString("Buckettxt.Items15"), resources.GetString("Buckettxt.Items16"), resources.GetString("Buckettxt.Items17"), resources.GetString("Buckettxt.Items18"), resources.GetString("Buckettxt.Items19"), resources.GetString("Buckettxt.Items20"), resources.GetString("Buckettxt.Items21"), resources.GetString("Buckettxt.Items22"), resources.GetString("Buckettxt.Items23"), resources.GetString("Buckettxt.Items24"), resources.GetString("Buckettxt.Items25"), resources.GetString("Buckettxt.Items26"), resources.GetString("Buckettxt.Items27"), resources.GetString("Buckettxt.Items28"), resources.GetString("Buckettxt.Items29"), resources.GetString("Buckettxt.Items30"), resources.GetString("Buckettxt.Items31"), resources.GetString("Buckettxt.Items32"), resources.GetString("Buckettxt.Items33")})
        resources.ApplyResources(Me.Buckettxt, "Buckettxt")
        Me.Buckettxt.Name = "Buckettxt"
        '
        'agvidtxt
        '
        Me.agvidtxt.FormattingEnabled = True
        Me.agvidtxt.Items.AddRange(New Object() {resources.GetString("agvidtxt.Items"), resources.GetString("agvidtxt.Items1"), resources.GetString("agvidtxt.Items2")})
        resources.ApplyResources(Me.agvidtxt, "agvidtxt")
        Me.agvidtxt.Name = "agvidtxt"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Sendpost
        '
        resources.ApplyResources(Me.Sendpost, "Sendpost")
        Me.Sendpost.Name = "Sendpost"
        Me.Sendpost.UseVisualStyleBackColor = True
        '
        'endpointtxt
        '
        resources.ApplyResources(Me.endpointtxt, "endpointtxt")
        Me.endpointtxt.Name = "endpointtxt"
        '
        'Jobpriortxt
        '
        resources.ApplyResources(Me.Jobpriortxt, "Jobpriortxt")
        Me.Jobpriortxt.Name = "Jobpriortxt"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Workfaceselect
        '
        Me.Workfaceselect.FormattingEnabled = True
        Me.Workfaceselect.Items.AddRange(New Object() {resources.GetString("Workfaceselect.Items"), resources.GetString("Workfaceselect.Items1"), resources.GetString("Workfaceselect.Items2"), resources.GetString("Workfaceselect.Items3")})
        resources.ApplyResources(Me.Workfaceselect, "Workfaceselect")
        Me.Workfaceselect.Name = "Workfaceselect"
        '
        'Robojobtxt
        '
        resources.ApplyResources(Me.Robojobtxt, "Robojobtxt")
        Me.Robojobtxt.Name = "Robojobtxt"
        '
        'LetDownFlagselect
        '
        Me.LetDownFlagselect.FormattingEnabled = True
        Me.LetDownFlagselect.Items.AddRange(New Object() {resources.GetString("LetDownFlagselect.Items"), resources.GetString("LetDownFlagselect.Items1")})
        resources.ApplyResources(Me.LetDownFlagselect, "LetDownFlagselect")
        Me.LetDownFlagselect.Name = "LetDownFlagselect"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'RoboJobID
        '
        resources.ApplyResources(Me.RoboJobID, "RoboJobID")
        Me.RoboJobID.Name = "RoboJobID"
        '
        'WarehouseIDtxt
        '
        resources.ApplyResources(Me.WarehouseIDtxt, "WarehouseIDtxt")
        Me.WarehouseIDtxt.Name = "WarehouseIDtxt"
        '
        'BucketID
        '
        resources.ApplyResources(Me.BucketID, "BucketID")
        Me.BucketID.Name = "BucketID"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Ytxt
        '
        resources.ApplyResources(Me.Ytxt, "Ytxt")
        Me.Ytxt.Name = "Ytxt"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'WorkFace
        '
        resources.ApplyResources(Me.WorkFace, "WorkFace")
        Me.WorkFace.Name = "WorkFace"
        '
        'Xtxt
        '
        resources.ApplyResources(Me.Xtxt, "Xtxt")
        Me.Xtxt.Name = "Xtxt"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'RichTextBox1
        '
        resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
        Me.RichTextBox1.Name = "RichTextBox1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Postto As ComboBox
    Friend WithEvents URLtxt As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Sendpost As Button
    Friend WithEvents RoboJobID As Label
    Friend WithEvents Robojobtxt As MaskedTextBox
    Friend WithEvents BucketID As Label
    Friend WithEvents Xtxt As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WorkFace As Label
    Friend WithEvents Ytxt As MaskedTextBox
    Friend WithEvents WarehouseIDtxt As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LetDownFlagselect As ComboBox
    Friend WithEvents Workfaceselect As ComboBox
    Friend WithEvents Jobpriortxt As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents endpointtxt As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents agvidtxt As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Buckettxt As ComboBox
    Friend WithEvents station As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
