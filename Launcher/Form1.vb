Imports System.Threading
Imports System.IO
Imports System.Text

Public Class Login
    Dim model(), characterName() As String
    Dim apiKey, chatVer, mode, stream, chara, base_url As String
    Dim ip, port As String
    Dim apiKeyConfig, chatVerConfig, modeConfig, actionBarText, streamConfig, showCommand, charaConfig, showLog, base_url_config, pyrun, SysEnvironmentCon As String
    Dim lastLine As String
    Dim configFile = Application.StartupPath & "/Config/config.ini"
    Dim modelFile = Application.StartupPath & "/Config/model.ini"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Shell("cmd /c del loglauncher.log")
        actionBarText = " 《数字生命》" & ReadConfig("uiconfig", "version", configFile)
        Thread.Sleep(500)
        'logData.Text = My.Settings.testmode
        ActionBar.Text = actionBarText
        logData.BackColor = Color.FromArgb(231, 231, 231)
        CheckForIllegalCrossThreadCalls = False
        Height = 700
        Width = 470
        Shell("cmd /c del log.log")
        Shell("cmd /c echo. > log.log")
        Shell("cmd /c echo. > logdata.txt")
        apiKeyConfig = ReadConfig("uiconfig", "apikey", configFile)
        chatVerConfig = ReadConfig("uiconfig", "chatver", configFile)
        modeConfig = ReadConfig("uiconfig", "model", configFile)
        streamConfig = ReadConfig("uiconfig", "stream", configFile)
        charaConfig = ReadConfig("uiconfig", "character", configFile)
        showLog = ReadConfig("uiconfig", "showlog", configFile)
        showCommand = ReadConfig("uiconfig", "showcommand", configFile)
        base_url_config = ReadConfig("uiconfig", "base_url", configFile)
        pyrun = ReadConfig("uiconfig", "pyrun", configFile)
        SysEnvironmentCon = ReadConfig("uiconfig", "SysEnviron", configFile)
        If chatVer = "1" Then
            OptionAPI.Checked = True
        ElseIf chatVer = "2" Then
            OptionAnthropic.Checked = True
        Else
            OptionGemini.Checked = True
        End If
        If showCommand = "True" Then
            Height = 700
        Else
            Height = 660
        End If
        Log("Starting launcher.")
        If base_url_config = "" Then
            base_url = ""
        Else
            base_url = " --base_url" & base_url_config
        End If
        If showLog = "True" Then
            Width = 1060
            CheckLog.Checked = True
        Else
            Width = 470
            CheckLog.Checked = False
        End If
        If apiKeyConfig = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & apiKeyConfig
            TextAPIKey.Text = apiKeyConfig
        End If
        If pyrun = "True" Then
            CheckNonEXE.Checked = True
        Else
            CheckNonEXE.Checked = False
        End If
        'End If

        '7
        'MsgBox(modeConfig)

        If OptionAPI.Checked Then
            Dim comboData = ReadConfig("model", "openai", modelFile)
            model = Split(comboData, ",")
            ComboModSelect.Items.Clear()
            For Each ii In model
                ComboModSelect.Items.Add(ii)
            Next ii
        ElseIf OptionAnthropic.Checked Then
            Dim comboData = ReadConfig("model", "anthropic", modelFile)
            model = Split(comboData, ",")
            ComboModSelect.Items.Clear()
            For Each ii In model
                ComboModSelect.Items.Add(ii)
            Next ii
        Else
            Dim comboData = ReadConfig("model", "gemini", modelFile)
            model = Split(comboData, ",")
            ComboModSelect.Items.Clear()
            For Each ii In model
                ComboModSelect.Items.Add(ii)
            Next ii
        End If
        ComboModSelect.Text = modeConfig



        '9
        If streamConfig = "True" Then
            CheckStream.Checked = True
            stream = " --stream True"

        Else
            stream = " --stream False"
            CheckStream.Checked = False
        End If
        If pyrun = "True" Then
            CheckStream.Checked = True

        Else
            CheckStream.Checked = False
        End If
        '10
        Dim comboDataCharacter = ReadConfig("model", "character", modelFile)
        model = Split(comboDataCharacter, ",")
        ComboCharacterSelect.Items.Clear()

        For Each u In model
            ComboCharacterSelect.Items.Add(u)
        Next u
        ComboCharacterSelect.Text = charaConfig



        mode = " --model " & modeConfig
        chara = " --character " & charaConfig

        chatVer = " --chatVer " & chatVerConfig
        'ComboModSelect.SelectedText = modeConfig
        UpdateCommand()

    End Sub

    Private Sub OptionAPI_CheckedChanged_1(sender As Object, e As EventArgs) Handles OptionAPI.CheckedChanged

    End Sub

    Private Sub OptionAPI_CheckedChanged(sender As Object, e As EventArgs) Handles OptionAPI.Click
        TextBaseUrl.Visible = True
        chatVer = " --chatVer 1"
        Dim comboData = ReadConfig("model", "openai", modelFile)
        model = Split(comboData, ",")
        ComboModSelect.Items.Clear()

        For Each ii In model
            ComboModSelect.Items.Add(ii)
        Next ii
        ComboModSelect.Text = modeConfig
        If TextAPIKey.Text = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & TextAPIKey.Text
        End If
        chatVerConfig = "1"
        My.Settings.Save()
        UpdateCommand()
    End Sub

    Private Sub OptionAnthropic_CheckedChanged(sender As Object, e As EventArgs) Handles OptionAnthropic.Click
        TextBaseUrl.Visible = True
        chatVer = " --chatVer 2"
        Dim comboData = ReadConfig("model", "anthropic", modelFile)
        model = Split(comboData, ",")
        ComboModSelect.Items.Clear()

        For Each ii In model
            ComboModSelect.Items.Add(ii)
        Next ii
        ComboModSelect.Text = modeConfig
        If TextAPIKey.Text = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & TextAPIKey.Text
        End If
        chatVerConfig = "2"
        My.Settings.Save()
        UpdateCommand()
    End Sub

    Private Sub OptionGemini_CheckedChanged(sender As Object, e As EventArgs) Handles OptionGemini.Click
        TextBaseUrl.Visible = False
        chatVer = " --chatVer 3"
        Dim comboData = ReadConfig("model", "gemini", modelFile)
        model = Split(comboData, ",")
        ComboModSelect.Items.Clear()

        For Each ii In model
            ComboModSelect.Items.Add(ii)
        Next ii
        ComboModSelect.Text = modeConfig
        If TextAPIKey.Text = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & TextAPIKey.Text
        End If
        chatVerConfig = "3"
        My.Settings.Save()
        UpdateCommand()
    End Sub

    Private Sub TextOpenAIAcc_Click_1(sender As Object, e As EventArgs) Handles TextAPIKey.TextChanged
        apiKey = " --APIKey " & TextAPIKey.Text

        UpdateCommand()
    End Sub

    Private Sub Textbaseurl_Click_1(sender As Object, e As EventArgs) Handles TextBaseUrl.TextChanged
        base_url = " --base_url " & TextBaseUrl.Text

        UpdateCommand()
    End Sub


    Private Sub CheckLog_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLog.CheckedChanged
        If CheckLog.Checked Then
            Width = 1070
        Else
            Width = 470
        End If
    End Sub

    Private Sub logData_TextChanged(sender As Object, e As EventArgs) Handles logData.TextChanged

    End Sub

    Private Sub CheckLog_NewCheckedChanged(sender As Object, e As EventArgs) Handles CheckLog.Click
        If CheckLog.Checked Then
            Width = 1060
        Else
            Width = 470
        End If
    End Sub

    Private Sub LaunchPH_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub GetAPI_Click(sender As Object, e As EventArgs)
        Shell("cmd /c start guide/getapi.html")
    End Sub

    Private Sub OptionGemini_CheckedChanged_1(sender As Object, e As EventArgs) Handles OptionGemini.CheckedChanged

    End Sub

    Private Sub ActionBar_Click(sender As Object, e As EventArgs) Handles ActionBar.Click
        If showCommand = "True" Then
            showCommand = "False"
            WriteConfig("uiconfig", "showcommand", "False", configFile)
            Height = 660
        Else
            showCommand = "True"
            WriteConfig("uiconfig", "showcommand", "True", configFile)
            Height = 700
        End If

    End Sub

    Private Sub TextStatus_Click_1(sender As Object, e As EventArgs) Handles TextStatus.Click
        If TextStatus.Text = "服务器已启动！点击此处选择客户端" Then
            SelectClient.Show()
        End If
    End Sub

    Private Sub GroupGPTVersion_Enter(sender As Object, e As EventArgs) Handles GroupGPTVersion.Enter

    End Sub

    Private Sub MaterialRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles OptionAnthropic.CheckedChanged

    End Sub

    'Private Sub TextStatus_Click(sender As Object, e As EventArgs) Handles TextStatus.MouseWheel
    '    Shell("cmd /c start loglauncher.log", vbHide)

    'End Sub

    Private Sub Editor_Click(sender As Object, e As EventArgs) Handles Editor.Click
        PromptEditor.Show()
    End Sub

    Private Sub ComboModSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboModSelect.SelectedIndexChanged
        'MsgBox(ComboModSelect.SelectedIndex)
        mode = " --model " & ComboModSelect.Text

        UpdateCommand()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles Launch.Click
        SaveConfig()

        'Shell("cmd /c del log_async.log")
        Shell("cmd /c echo. > log_async.log")
        Dim launcher As New Thread(AddressOf StartServer)
        launcher.Start()
    End Sub

    Sub StartServer()
        Log("Starting socketserver.")
        Launch.Text = "启动中"
        TextStatus.Text = "正在启动..."
        TextStatus.BackColor = Color.Red

        'Dim confirm As String
        'confirm = Msgbox2(Me, "服务器已启动", "请选择客户端类型", "手机端", True, "电脑端")
        'If confirm = "OK" Then
        '    MsgBox("OK")
        'Else
        '    MsgBox("no")
        'End If

        'Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
        'Shell("cmd /c taskkill /f /t /im T.exe", vbHide)
        SelectClient.Close()
        Thread.Sleep(1000)
        Shell("cmd /c " & para.Text, vbHide)
        Log("Using flags：" & para.Text)
        Dim logContent, logSpliter(), lastContent, totalContent() As String
        Dim totalLine As Integer
        Do


            Thread.Sleep(1000)
            'Log("Read log_async.log.")
            logContent = File.ReadAllText("log_async.log", Encoding.Default)
            logSpliter = Split(logContent, " INFO ")
            totalContent = Split(logContent, vbCrLf)
            totalLine = UBound(totalContent)
            logData.Text = logContent + vbCrLf
            logData.SelectionStart = logData.Text.Length
            logData.ScrollToCaret()

            'If totalLine < 32 Then
            '    logData.Text = logContent
            'Else
            '    'AuxData.Text = ""
            '    For i = totalLine - 32 To totalLine
            '        AuxData.AppendText(totalContent(i) + vbCrLf)
            '    Next i

            '    File.WriteAllText("temp", AuxData.Text)
            '    logData.Text = File.ReadAllText("temp")
            'End If
            Try
                lastContent = logSpliter(UBound(logSpliter))
                'If lastContent.Contains("退出") Then
                '    Log("Detect [退出] keyword, kill all process.")

                '    Shell("cmd /c taskkill /f /t /im Launcher.exe", vbHide)
                '    Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
                '    Shell("cmd /c taskkill /f /t /im T.exe", vbHide)
                'End If

                If logContent.Contains("Initializing Server") Then
                    If Not SC("tasklist | findstr /i SocketServer.exe").Contains("Console") Then

                        Log("Socketserver status: offline !!!")
                        TextStatus.Text = "未启动"
                        TextStatus.BackColor = Color.Red
                        logData.AppendText(vbCrLf + "服务器进程已退出！")
                        'Shell("cmd /c taskkill /f /t /im T.exe", vbHide)

                        Exit Do
                    Else
                        Log("Socketserver status: online.")
                    End If
                End If


                If lastContent.Contains("Server is listening on") Then
                    Log("Waiting for connection...")


                    Dim ipData() = Split(logSpliter(UBound(logSpliter)), ":")
                    ip = "0.0.0.0"
                    port = Replace(ipData(1), "...", "")
                    Launch.Text = "重启服务器"
                    TextStatus.Text = "服务已启动。点击此处选择客户端"
                    'TextStatus.Text = "服务器已启动"
                    IPBox.Text = ip
                    PortBox.Text = Replace(port, vbCrLf, "")
                    'SelectClient.Show()
                    TextStatus.BackColor = Color.FromArgb(0, 192, 0)
                    'TextStatus.p
                    Thread.Sleep(2000)

                End If

                If lastContent.Contains("Connected by") Then
                    Log("Client connected.")

                    Launch.Text = "重启服务器"
                    TextStatus.Text = "已连接"
                    SelectClient.Close()
                    'LaunchPH.Enabled = False
                    'LaunchUE.Enabled = False

                End If

                If lastContent.Contains("WinError") Then
                    Log("Client disconnected.")

                    Launch.Text = "重启服务器"
                    TextStatus.Text = "未启动"
                    TextStatus.BackColor = Color.Red
                    'Dim confirm As String
                    'confirm = Msgbox2(Me, "客户端已断开", "请选择客户端类型重新连接", "电脑端", True, "手机端")
                    'If confirm = "OK" Then
                    '    Log("Starting UE process")

                    '    Shell("cmd /c Client\T.exe -ip=" & ip & " -port=" & port, vbHide)
                    'Else
                    '    AndroidApk.Show()

                    'End If

                End If
                logData.Focus()
                logData.ScrollToCaret()

            Catch
            End Try
        Loop
        logData.Height = 584
        Dim ipRawData() As String

        ipRawData = Split(File.ReadAllText("logdata.txt"), "Server is listening on ")

    End Sub

    Private Sub ComboCharacterSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCharacterSelect.SelectedIndexChanged
        chara = " --character " & ComboCharacterSelect.Text
        UpdateCommand()
    End Sub

    Private Sub CheckStream_CheckedChanged(sender As Object, e As EventArgs) Handles CheckStream.CheckedChanged
        If CheckStream.Checked Then
            stream = " --stream True"
            WriteConfig("uiconfig", "stream", "True", configFile)

        Else
            stream = " --stream False"
            WriteConfig("uiconfig", "stream", "False", configFile)


        End If
        My.Settings.Save()
        UpdateCommand()
    End Sub

    Private Sub ChekNonEXE_CheckedChanged(sender As Object, e As EventArgs) Handles CheckNonEXE.CheckedChanged
        UpdateCommand()
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveConfig()
        Msgbox2(Me, "成功", "已保存配置！",, False, )
    End Sub

    Private Sub OptionAccAndPass_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Sub UpdateCommand()
        If TextAPIKey.Text = "" Then
            apiKey = ""
        End If
        If TextBaseUrl.Text = "" Then
            base_url = ""
        End If
        If CheckNonEXE.Checked Then
            para.Text = ".venv/Scripts/python.exe SocketServer.py" & chatVer & apiKey & mode & stream & chara & base_url
        Else
            para.Text = "SocketServer.exe " & chatVer & apiKey & mode & stream & chara & base_url
        End If
        Log("Command update：" & para.Text)

    End Sub

    Private Sub CloseForm() Handles Me.FormClosed

        Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
        Shell("cmd /c taskkill /f /t /im Launcher.exe", vbHide)

    End Sub

    Sub SaveConfig()
        'Log("Save all config.")
        WriteConfig("uiconfig", "chatVer", chatVer, configFile)
        WriteConfig("uiconfig", "apikey", TextAPIKey.Text, configFile)
        WriteConfig("uiconfig", "model", ComboModSelect.Text, configFile)
        WriteConfig("uiconfig", "base_url", TextBaseUrl.Text, configFile)

        If CheckStream.Checked Then
            WriteConfig("uiconfig", "stream", "True", configFile)
        Else
            WriteConfig("uiconfig", "stream", "False", configFile)

        End If
        If CheckNonEXE.Checked Then
            WriteConfig("uiconfig", "pyrun", "True", configFile)
        Else
            WriteConfig("uiconfig", "pyrun", "False", configFile)

        End If
        WriteConfig("uiconfig", "character", ComboCharacterSelect.Text, configFile)

        If CheckLog.Checked Then

            WriteConfig("uiconfig", "showlog", "True", configFile)

        Else
            WriteConfig("uiconfig", "showlog", "False", configFile)

        End If
    End Sub

End Class



'"--chatVer", type = int, required = True) 接入chatgpt版本，1为网页版，3为api版
'    "--APIKey", type = str, required = False) chatVer=3专用：openAI的API Key, 不填就用我们的服务器， 有流量限制。
'    "--email", type = str, required = False) chatVer=1专用：openAI账号
'"--password", type = str, required = False) chatVer=1专用：openAI密码
'"--accessToken", type = str, required = False) chatVer=1专用：openAI cookie，
'    "--proxy", type=str, required=False) 代理服务器链接，用clash可以设置成127.0.0.1:7890
'    "--paid", type = bool, required = False) chatVer=1专用：是否为plus账号 True / False
'    "--model", type = str, required = False) 模型选择，chatVer=1时且
'    "--stream", type = bool, required = True) 是否流式输出语音 True/False
'    "--character", type = str, required = True) 角色选择，现在有两个 paimon yunfei