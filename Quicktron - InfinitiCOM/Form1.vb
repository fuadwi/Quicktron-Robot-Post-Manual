Imports System.Net
Imports System.IO
Imports System.Text

Public Class Form1
    Dim Logincookie As CookieContainer

    Public postdatasubmit As String
    Public xval As Single
    Public yval As Single
    Public endpointval As Single
    Public postdatasubmit1 As String
    Public xval1 As Single
    Public yval1 As Single
    Public endpointval1 As Single`
    Public Function postData1(ByRef URL As String, ByRef POST As String, ByRef Cookies As CookieContainer)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        request = CType(WebRequest.Create(URL), HttpWebRequest)
        request.ContentType = "application/json"
        MsgBox(POST)
        'Posttxt.Text = POST
        request.ContentLength = POST.Length
        request.Method = "POST"
        request.AllowAutoRedirect = False
        Dim requeststream As Stream = request.GetRequestStream()
        Dim postBytes As Byte() = Encoding.ASCII.GetBytes(POST)
        requeststream.Write(postBytes, 0, postBytes.Length)
        requeststream.Close()
        response = CType(request.GetResponse(), HttpWebResponse)
        Return New StreamReader(response.GetResponseStream()).ReadToEnd()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub Postto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Postto.SelectedIndexChanged


        If (Postto.Text = "Submit") Then
            URLtxt.Text = "http://192.168.20.20:8080/wcs/robot/job/submit"
            Robojobtxt.Enabled = True
            WarehouseIDtxt.Enabled = True
            Buckettxt.Enabled = True
            Xtxt.Enabled = True
            Ytxt.Enabled = True
            Workfaceselect.Enabled = True
            Workfaceselect.Enabled = True
            Workfaceselect.Enabled = True
            Jobpriortxt.Enabled = True
            LetDownFlagselect.Enabled = True
            agvidtxt.Enabled = False
        ElseIf (Postto.Text = "Cancel") Then
            URLtxt.Text = "http://192.168.20.20:8080/wcs/robot/job/cancel"
            Robojobtxt.Enabled = True
            WarehouseIDtxt.Enabled = True
            Buckettxt.Enabled = False
            Xtxt.Enabled = True
            Ytxt.Enabled = True
            agvidtxt.Enabled = False
            Workfaceselect.Enabled = False
            Jobpriortxt.Enabled = False
            LetDownFlagselect.Enabled = False
            agvidtxt.Enabled = False
        ElseIf (Postto.Text = "Bucket Query") Then
            URLtxt.Text = "http://192.168.20.20:8080/wcs/bucket/Query"
            agvidtxt.Enabled = False
            WarehouseIDtxt.Enabled = True
            Buckettxt.Enabled = True
            Robojobtxt.Enabled = False
            Xtxt.Enabled = False
            Ytxt.Enabled = False
            endpointtxt.Enabled = False

            Workfaceselect.Enabled = False
            Jobpriortxt.Enabled = False
            LetDownFlagselect.Enabled = False
        ElseIf (Postto.Text = "AGV Query") Then
            URLtxt.Text = "http://192.168.20.20:8080/wcs/agv/query"
            agvidtxt.Enabled = True
            Robojobtxt.Enabled = False
            WarehouseIDtxt.Enabled = True
            Buckettxt.Enabled = False
            Xtxt.Enabled = False
            Ytxt.Enabled = False
            Workfaceselect.Enabled = False
            Jobpriortxt.Enabled = False
            LetDownFlagselect.Enabled = False
        End If

    End Sub
    Private Sub station_SelectedIndexChanged(sender As Object, e As EventArgs) Handles station.SelectedIndexChanged
        If (station.Text = "Putting Station") Then
            Xtxt.Text = "35"
            Ytxt.Text = "22"
            LetDownFlagselect.Text = "online"
        ElseIf (station.Text = "Picking Station") Then
            Xtxt.Text = "20"
            Ytxt.Text = "22"
            LetDownFlagselect.Text = "online"
        End If
    End Sub



    'tambahan belum selesai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim postdatasubmit1 As String
        Dim dataforpost1 As String

        Try
            If (Buckettxt = "1") Then
                Xtxt.Text = "20"
                Ytxt.Text = "20"
            End If
            xval1 = Xtxt.Text
            yval1 = Ytxt.Text
            endpointval1 = (xval1 * 65536) + yval1
            If (Postto.Text = "Submit") Then
                postdatasubmit1 = "{""robotJobId"":""RJI_" & Robojobtxt.Text & """,""warehouseId"":""" & WarehouseIDtxt.Text & """,""bucketId"":""" & Buckettxt.Text & """,""workFace"":""" & Workfaceselect.Text & """,""endPoint"":""" & endpointtxt.Text & """,""letDownFlag"":""" & LetDownFlagselect.Text & """,""jobPriority"":""" & Jobpriortxt.Text & """}"
            End If

        Catch ex As Exception

        End Try
    End Sub
    'sampai sini gaes

    Private Sub Sendpost_Click(sender As Object, e As EventArgs) Handles Sendpost.Click
        Dim postdatasubmit As String
        Dim dataforpost As String = (postData1(URLtxt.Text, postdatasubmit, New CookieContainer))
        Dim result As String

        Try
            xval = Xtxt.Text
            yval = Ytxt.Text

            endpointval = (xval * 65536) + yval
            endpointtxt.Text = endpointval
            If (Postto.Text = "Submit") Then
                postdatasubmit = "{""robotJobId"":""RJI_" & Robojobtxt.Text & """,""warehouseId"":""" & WarehouseIDtxt.Text & """,""bucketId"":""" & Buckettxt.Text & """,""workFace"":""" & Workfaceselect.Text & """,""endPoint"":""" & endpointtxt.Text & """,""letDownFlag"":""" & LetDownFlagselect.Text & """,""jobPriority"":""" & Jobpriortxt.Text & """}"
            ElseIf (Postto.Text = "Cancel") Then
                postdatasubmit = "{""robotJobId"":""RJI_" & Robojobtxt.Text & """,""warehouseId"":""" & WarehouseIDtxt.Text & """,""bucketId"":""" & Buckettxt.Text & """,""endPoint"":""" & endpointtxt.Text & """}"
            ElseIf (Postto.Text = "AGV Query") Then
                postdatasubmit = "{""warehouseId"":""" & WarehouseIDtxt.Text & """,""agvCodeList"":""" & agvidtxt.Text & """}"
            ElseIf (Postto.Text = "Bucket Query") Then
                postdatasubmit = "{""warehouseId"":""" & WarehouseIDtxt.Text & """,""bucketId"":""" & Buckettxt.Text & """}"

            End If
        Catch ex1 As Exception
            MsgBox(ex1.Message)
        End Try
        Try
            RichTextBox1.Text = (postData1(URLtxt.Text, postdatasubmit, New CookieContainer))
            result = CStr(dataforpost.Contains("success"))
            If result = "true" Then
                RichTextBox1.Enabled = True

            End If
            'MsgBox(postData1(URLtxt.Text, postdatasubmit, New CookieContainer))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub




End Class
