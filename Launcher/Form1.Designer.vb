<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupGPTVersion = New System.Windows.Forms.GroupBox()
        Me.CustonModel = New MaterialSkin.Controls.MaterialCheckbox()
        Me.SysEnvironment = New MaterialSkin.Controls.MaterialCheckbox()
        Me.CheckNonEXE = New MaterialSkin.Controls.MaterialCheckbox()
        Me.OptionAnthropic = New MaterialSkin.Controls.MaterialRadioButton()
        Me.OptionGemini = New MaterialSkin.Controls.MaterialRadioButton()
        Me.TextBaseUrl = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.CheckStream = New MaterialSkin.Controls.MaterialCheckbox()
        Me.ComboCharacterSelect = New MaterialSkin.Controls.MaterialComboBox()
        Me.TextAPIKey = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.OptionAPI = New MaterialSkin.Controls.MaterialRadioButton()
        Me.CustomModelInput = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.ComboModSelect = New MaterialSkin.Controls.MaterialComboBox()
        Me.Launch = New MaterialSkin.Controls.MaterialButton()
        Me.ActionBar = New System.Windows.Forms.Label()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.para = New System.Windows.Forms.TextBox()
        Me.logData = New System.Windows.Forms.TextBox()
        Me.Save = New MaterialSkin.Controls.MaterialButton()
        Me.TextStatus = New System.Windows.Forms.Label()
        Me.CheckLog = New MaterialSkin.Controls.MaterialCheckbox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Editor = New MaterialSkin.Controls.MaterialButton()
        Me.IPBox = New System.Windows.Forms.TextBox()
        Me.PortBox = New System.Windows.Forms.TextBox()
        Me.GroupGPTVersion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupGPTVersion
        '
        Me.GroupGPTVersion.BackColor = System.Drawing.SystemColors.Control
        Me.GroupGPTVersion.Controls.Add(Me.CustonModel)
        Me.GroupGPTVersion.Controls.Add(Me.SysEnvironment)
        Me.GroupGPTVersion.Controls.Add(Me.CheckNonEXE)
        Me.GroupGPTVersion.Controls.Add(Me.OptionAnthropic)
        Me.GroupGPTVersion.Controls.Add(Me.OptionGemini)
        Me.GroupGPTVersion.Controls.Add(Me.TextBaseUrl)
        Me.GroupGPTVersion.Controls.Add(Me.CheckStream)
        Me.GroupGPTVersion.Controls.Add(Me.ComboCharacterSelect)
        Me.GroupGPTVersion.Controls.Add(Me.TextAPIKey)
        Me.GroupGPTVersion.Controls.Add(Me.OptionAPI)
        Me.GroupGPTVersion.Controls.Add(Me.ComboModSelect)
        Me.GroupGPTVersion.Controls.Add(Me.CustomModelInput)
        Me.GroupGPTVersion.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupGPTVersion.Location = New System.Drawing.Point(36, 132)
        Me.GroupGPTVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupGPTVersion.Name = "GroupGPTVersion"
        Me.GroupGPTVersion.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupGPTVersion.Size = New System.Drawing.Size(636, 684)
        Me.GroupGPTVersion.TabIndex = 3
        Me.GroupGPTVersion.TabStop = False
        Me.GroupGPTVersion.Text = "API类型"
        '
        'CustonModel
        '
        Me.CustonModel.Depth = 0
        Me.CustonModel.Location = New System.Drawing.Point(484, 600)
        Me.CustonModel.Margin = New System.Windows.Forms.Padding(0)
        Me.CustonModel.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CustonModel.MouseState = MaterialSkin.MouseState.HOVER
        Me.CustonModel.Name = "CustonModel"
        Me.CustonModel.ReadOnly = False
        Me.CustonModel.Ripple = True
        Me.CustonModel.Size = New System.Drawing.Size(148, 60)
        Me.CustonModel.TabIndex = 44
        Me.CustonModel.Text = "自定义模型"
        Me.ToolTip1.SetToolTip(Me.CustonModel, "输入自己的模型。")
        Me.CustonModel.UseVisualStyleBackColor = True
        '
        'SysEnvironment
        '
        Me.SysEnvironment.Depth = 0
        Me.SysEnvironment.Location = New System.Drawing.Point(184, 524)
        Me.SysEnvironment.Margin = New System.Windows.Forms.Padding(0)
        Me.SysEnvironment.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SysEnvironment.MouseState = MaterialSkin.MouseState.HOVER
        Me.SysEnvironment.Name = "SysEnvironment"
        Me.SysEnvironment.ReadOnly = False
        Me.SysEnvironment.Ripple = True
        Me.SysEnvironment.Size = New System.Drawing.Size(148, 60)
        Me.SysEnvironment.TabIndex = 43
        Me.SysEnvironment.Text = "系统环境"
        Me.ToolTip1.SetToolTip(Me.SysEnvironment, "使用系统Python环境运行。")
        Me.SysEnvironment.UseVisualStyleBackColor = True
        Me.SysEnvironment.Visible = False
        '
        'CheckNonEXE
        '
        Me.CheckNonEXE.Depth = 0
        Me.CheckNonEXE.Location = New System.Drawing.Point(36, 524)
        Me.CheckNonEXE.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckNonEXE.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckNonEXE.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckNonEXE.Name = "CheckNonEXE"
        Me.CheckNonEXE.ReadOnly = False
        Me.CheckNonEXE.Ripple = True
        Me.CheckNonEXE.Size = New System.Drawing.Size(148, 60)
        Me.CheckNonEXE.TabIndex = 41
        Me.CheckNonEXE.Text = "解释运行"
        Me.ToolTip1.SetToolTip(Me.CheckNonEXE, "运行Python源代码而非编译后的可执行文件。")
        Me.CheckNonEXE.UseVisualStyleBackColor = True
        '
        'OptionAnthropic
        '
        Me.OptionAnthropic.AutoSize = True
        Me.OptionAnthropic.Depth = 0
        Me.OptionAnthropic.Location = New System.Drawing.Point(233, 42)
        Me.OptionAnthropic.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionAnthropic.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionAnthropic.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionAnthropic.Name = "OptionAnthropic"
        Me.OptionAnthropic.Ripple = True
        Me.OptionAnthropic.Size = New System.Drawing.Size(103, 37)
        Me.OptionAnthropic.TabIndex = 40
        Me.OptionAnthropic.TabStop = True
        Me.OptionAnthropic.Text = "Anthropic"
        Me.ToolTip1.SetToolTip(Me.OptionAnthropic, "使用Anthropic API接入")
        Me.OptionAnthropic.UseVisualStyleBackColor = True
        '
        'OptionGemini
        '
        Me.OptionGemini.AutoSize = True
        Me.OptionGemini.Depth = 0
        Me.OptionGemini.Location = New System.Drawing.Point(437, 42)
        Me.OptionGemini.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionGemini.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionGemini.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionGemini.Name = "OptionGemini"
        Me.OptionGemini.Ripple = True
        Me.OptionGemini.Size = New System.Drawing.Size(85, 37)
        Me.OptionGemini.TabIndex = 39
        Me.OptionGemini.TabStop = True
        Me.OptionGemini.Text = "Gemini"
        Me.ToolTip1.SetToolTip(Me.OptionGemini, "使用Gemini API接入")
        Me.OptionGemini.UseVisualStyleBackColor = True
        '
        'TextBaseUrl
        '
        Me.TextBaseUrl.AllowPromptAsInput = True
        Me.TextBaseUrl.AnimateReadOnly = False
        Me.TextBaseUrl.AsciiOnly = False
        Me.TextBaseUrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextBaseUrl.BeepOnError = False
        Me.TextBaseUrl.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextBaseUrl.Depth = 0
        Me.TextBaseUrl.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextBaseUrl.HidePromptOnLeave = False
        Me.TextBaseUrl.HideSelection = True
        Me.TextBaseUrl.Hint = "自定义Base URL(可选)"
        Me.TextBaseUrl.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextBaseUrl.LeadingIcon = Nothing
        Me.TextBaseUrl.Location = New System.Drawing.Point(36, 183)
        Me.TextBaseUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBaseUrl.Mask = ""
        Me.TextBaseUrl.MaxLength = 32767
        Me.TextBaseUrl.MouseState = MaterialSkin.MouseState.OUT
        Me.TextBaseUrl.Name = "TextBaseUrl"
        Me.TextBaseUrl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBaseUrl.PrefixSuffixText = Nothing
        Me.TextBaseUrl.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextBaseUrl.ReadOnly = False
        Me.TextBaseUrl.RejectInputOnFirstFailure = False
        Me.TextBaseUrl.ResetOnPrompt = True
        Me.TextBaseUrl.ResetOnSpace = True
        Me.TextBaseUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBaseUrl.SelectedText = ""
        Me.TextBaseUrl.SelectionLength = 0
        Me.TextBaseUrl.SelectionStart = 0
        Me.TextBaseUrl.ShortcutsEnabled = True
        Me.TextBaseUrl.Size = New System.Drawing.Size(564, 36)
        Me.TextBaseUrl.SkipLiterals = True
        Me.TextBaseUrl.TabIndex = 38
        Me.TextBaseUrl.TabStop = False
        Me.TextBaseUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBaseUrl.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextBaseUrl.TrailingIcon = Nothing
        Me.TextBaseUrl.UseSystemPasswordChar = False
        Me.TextBaseUrl.UseTallSize = False
        Me.TextBaseUrl.ValidatingType = Nothing
        '
        'CheckStream
        '
        Me.CheckStream.Depth = 0
        Me.CheckStream.Location = New System.Drawing.Point(300, 600)
        Me.CheckStream.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckStream.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckStream.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckStream.Name = "CheckStream"
        Me.CheckStream.ReadOnly = False
        Me.CheckStream.Ripple = True
        Me.CheckStream.Size = New System.Drawing.Size(148, 60)
        Me.CheckStream.TabIndex = 37
        Me.CheckStream.Text = "流式语音"
        Me.ToolTip1.SetToolTip(Me.CheckStream, "每一个完整句子都会生成一次语音，可以显著改善回答延迟问题")
        Me.CheckStream.UseVisualStyleBackColor = True
        '
        'ComboCharacterSelect
        '
        Me.ComboCharacterSelect.AutoResize = False
        Me.ComboCharacterSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboCharacterSelect.Depth = 0
        Me.ComboCharacterSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboCharacterSelect.DropDownHeight = 174
        Me.ComboCharacterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCharacterSelect.DropDownWidth = 121
        Me.ComboCharacterSelect.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ComboCharacterSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboCharacterSelect.FormattingEnabled = True
        Me.ComboCharacterSelect.Hint = "角色选择"
        Me.ComboCharacterSelect.IntegralHeight = False
        Me.ComboCharacterSelect.ItemHeight = 43
        Me.ComboCharacterSelect.Location = New System.Drawing.Point(36, 588)
        Me.ComboCharacterSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboCharacterSelect.MaxDropDownItems = 4
        Me.ComboCharacterSelect.MouseState = MaterialSkin.MouseState.OUT
        Me.ComboCharacterSelect.Name = "ComboCharacterSelect"
        Me.ComboCharacterSelect.Size = New System.Drawing.Size(250, 49)
        Me.ComboCharacterSelect.StartIndex = 0
        Me.ComboCharacterSelect.TabIndex = 36
        '
        'TextAPIKey
        '
        Me.TextAPIKey.AllowPromptAsInput = True
        Me.TextAPIKey.AnimateReadOnly = False
        Me.TextAPIKey.AsciiOnly = False
        Me.TextAPIKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextAPIKey.BeepOnError = False
        Me.TextAPIKey.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextAPIKey.Depth = 0
        Me.TextAPIKey.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextAPIKey.HidePromptOnLeave = False
        Me.TextAPIKey.HideSelection = True
        Me.TextAPIKey.Hint = "API Key"
        Me.TextAPIKey.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextAPIKey.LeadingIcon = Nothing
        Me.TextAPIKey.Location = New System.Drawing.Point(36, 108)
        Me.TextAPIKey.Margin = New System.Windows.Forms.Padding(4)
        Me.TextAPIKey.Mask = ""
        Me.TextAPIKey.MaxLength = 32767
        Me.TextAPIKey.MouseState = MaterialSkin.MouseState.OUT
        Me.TextAPIKey.Name = "TextAPIKey"
        Me.TextAPIKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextAPIKey.PrefixSuffixText = Nothing
        Me.TextAPIKey.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextAPIKey.ReadOnly = False
        Me.TextAPIKey.RejectInputOnFirstFailure = False
        Me.TextAPIKey.ResetOnPrompt = True
        Me.TextAPIKey.ResetOnSpace = True
        Me.TextAPIKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextAPIKey.SelectedText = ""
        Me.TextAPIKey.SelectionLength = 0
        Me.TextAPIKey.SelectionStart = 0
        Me.TextAPIKey.ShortcutsEnabled = True
        Me.TextAPIKey.Size = New System.Drawing.Size(564, 36)
        Me.TextAPIKey.SkipLiterals = True
        Me.TextAPIKey.TabIndex = 18
        Me.TextAPIKey.TabStop = False
        Me.TextAPIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextAPIKey.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextAPIKey.TrailingIcon = Nothing
        Me.TextAPIKey.UseSystemPasswordChar = False
        Me.TextAPIKey.UseTallSize = False
        Me.TextAPIKey.ValidatingType = Nothing
        '
        'OptionAPI
        '
        Me.OptionAPI.AutoSize = True
        Me.OptionAPI.Depth = 0
        Me.OptionAPI.Location = New System.Drawing.Point(36, 42)
        Me.OptionAPI.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionAPI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionAPI.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionAPI.Name = "OptionAPI"
        Me.OptionAPI.Ripple = True
        Me.OptionAPI.Size = New System.Drawing.Size(86, 37)
        Me.OptionAPI.TabIndex = 4
        Me.OptionAPI.TabStop = True
        Me.OptionAPI.Text = "OpenAI"
        Me.ToolTip1.SetToolTip(Me.OptionAPI, "使用OpenAI API接入")
        Me.OptionAPI.UseVisualStyleBackColor = True
        '
        'CustomModelInput
        '
        Me.CustomModelInput.AllowPromptAsInput = True
        Me.CustomModelInput.AnimateReadOnly = False
        Me.CustomModelInput.AsciiOnly = False
        Me.CustomModelInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CustomModelInput.BeepOnError = False
        Me.CustomModelInput.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.CustomModelInput.Depth = 0
        Me.CustomModelInput.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.CustomModelInput.HidePromptOnLeave = False
        Me.CustomModelInput.HideSelection = True
        Me.CustomModelInput.Hint = "自定义模型"
        Me.CustomModelInput.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.CustomModelInput.LeadingIcon = Nothing
        Me.CustomModelInput.Location = New System.Drawing.Point(36, 263)
        Me.CustomModelInput.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomModelInput.Mask = ""
        Me.CustomModelInput.MaxLength = 32767
        Me.CustomModelInput.MouseState = MaterialSkin.MouseState.OUT
        Me.CustomModelInput.Name = "CustomModelInput"
        Me.CustomModelInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CustomModelInput.PrefixSuffixText = Nothing
        Me.CustomModelInput.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.CustomModelInput.ReadOnly = False
        Me.CustomModelInput.RejectInputOnFirstFailure = False
        Me.CustomModelInput.ResetOnPrompt = True
        Me.CustomModelInput.ResetOnSpace = True
        Me.CustomModelInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CustomModelInput.SelectedText = ""
        Me.CustomModelInput.SelectionLength = 0
        Me.CustomModelInput.SelectionStart = 0
        Me.CustomModelInput.ShortcutsEnabled = True
        Me.CustomModelInput.Size = New System.Drawing.Size(564, 36)
        Me.CustomModelInput.SkipLiterals = True
        Me.CustomModelInput.TabIndex = 42
        Me.CustomModelInput.TabStop = False
        Me.CustomModelInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CustomModelInput.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.CustomModelInput.TrailingIcon = Nothing
        Me.CustomModelInput.UseSystemPasswordChar = False
        Me.CustomModelInput.UseTallSize = False
        Me.CustomModelInput.ValidatingType = Nothing
        Me.CustomModelInput.Visible = False
        '
        'ComboModSelect
        '
        Me.ComboModSelect.AutoResize = False
        Me.ComboModSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboModSelect.Depth = 0
        Me.ComboModSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboModSelect.DropDownHeight = 118
        Me.ComboModSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboModSelect.DropDownWidth = 121
        Me.ComboModSelect.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ComboModSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboModSelect.FormattingEnabled = True
        Me.ComboModSelect.Hint = "模型选择"
        Me.ComboModSelect.IntegralHeight = False
        Me.ComboModSelect.ItemHeight = 29
        Me.ComboModSelect.Location = New System.Drawing.Point(36, 263)
        Me.ComboModSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboModSelect.MaxDropDownItems = 4
        Me.ComboModSelect.MouseState = MaterialSkin.MouseState.OUT
        Me.ComboModSelect.Name = "ComboModSelect"
        Me.ComboModSelect.Size = New System.Drawing.Size(562, 35)
        Me.ComboModSelect.StartIndex = 0
        Me.ComboModSelect.TabIndex = 24
        Me.ComboModSelect.UseTallSize = False
        '
        'Launch
        '
        Me.Launch.AutoSize = False
        Me.Launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Launch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Launch.Depth = 0
        Me.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Launch.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Launch.HighEmphasis = True
        Me.Launch.Icon = Nothing
        Me.Launch.Location = New System.Drawing.Point(36, 912)
        Me.Launch.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Launch.MouseState = MaterialSkin.MouseState.HOVER
        Me.Launch.Name = "Launch"
        Me.Launch.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Launch.Size = New System.Drawing.Size(156, 60)
        Me.Launch.TabIndex = 15
        Me.Launch.Text = "启动服务器"
        Me.ToolTip1.SetToolTip(Me.Launch, "启动服务")
        Me.Launch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Launch.UseAccentColor = False
        Me.Launch.UseVisualStyleBackColor = True
        '
        'ActionBar
        '
        Me.ActionBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ActionBar.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ActionBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ActionBar.Location = New System.Drawing.Point(0, 36)
        Me.ActionBar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActionBar.Name = "ActionBar"
        Me.ActionBar.Size = New System.Drawing.Size(1692, 72)
        Me.ActionBar.TabIndex = 16
        Me.ActionBar.Text = " 《数字生命》"
        Me.ActionBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(1500, 1152)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(190, 37)
        Me.MaterialRadioButton1.TabIndex = 1
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "MaterialRadioButton1"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'para
        '
        Me.para.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.para.Location = New System.Drawing.Point(36, 996)
        Me.para.Margin = New System.Windows.Forms.Padding(4)
        Me.para.Multiline = True
        Me.para.Name = "para"
        Me.para.Size = New System.Drawing.Size(1534, 34)
        Me.para.TabIndex = 26
        '
        'logData
        '
        Me.logData.BackColor = System.Drawing.SystemColors.Menu
        Me.logData.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.logData.Location = New System.Drawing.Point(720, 144)
        Me.logData.Margin = New System.Windows.Forms.Padding(4)
        Me.logData.Multiline = True
        Me.logData.Name = "logData"
        Me.logData.ReadOnly = True
        Me.logData.Size = New System.Drawing.Size(850, 826)
        Me.logData.TabIndex = 30
        '
        'Save
        '
        Me.Save.AutoSize = False
        Me.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Save.Depth = 0
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Save.HighEmphasis = True
        Me.Save.Icon = Nothing
        Me.Save.Location = New System.Drawing.Point(36, 840)
        Me.Save.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Save.MouseState = MaterialSkin.MouseState.HOVER
        Me.Save.Name = "Save"
        Me.Save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Save.Size = New System.Drawing.Size(156, 48)
        Me.Save.TabIndex = 31
        Me.Save.Text = "保存配置"
        Me.ToolTip1.SetToolTip(Me.Save, "保存所有配置项")
        Me.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Save.UseAccentColor = False
        Me.Save.UseVisualStyleBackColor = True
        '
        'TextStatus
        '
        Me.TextStatus.BackColor = System.Drawing.Color.Red
        Me.TextStatus.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextStatus.Location = New System.Drawing.Point(204, 912)
        Me.TextStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextStatus.Name = "TextStatus"
        Me.TextStatus.Size = New System.Drawing.Size(336, 60)
        Me.TextStatus.TabIndex = 33
        Me.TextStatus.Text = "未启动"
        Me.TextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckLog
        '
        Me.CheckLog.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckLog.Depth = 0
        Me.CheckLog.Location = New System.Drawing.Point(552, 915)
        Me.CheckLog.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckLog.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckLog.Name = "CheckLog"
        Me.CheckLog.ReadOnly = False
        Me.CheckLog.Ripple = True
        Me.CheckLog.Size = New System.Drawing.Size(120, 60)
        Me.CheckLog.TabIndex = 40
        Me.CheckLog.Text = "日志"
        Me.ToolTip1.SetToolTip(Me.CheckLog, "显示实时日志")
        Me.CheckLog.UseVisualStyleBackColor = True
        '
        'Editor
        '
        Me.Editor.AutoSize = False
        Me.Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Editor.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Lower
        Me.Editor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Editor.Depth = 0
        Me.Editor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editor.HighEmphasis = True
        Me.Editor.Icon = Nothing
        Me.Editor.Location = New System.Drawing.Point(204, 840)
        Me.Editor.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Editor.MouseState = MaterialSkin.MouseState.HOVER
        Me.Editor.Name = "Editor"
        Me.Editor.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Editor.Size = New System.Drawing.Size(168, 48)
        Me.Editor.TabIndex = 39
        Me.Editor.Text = "编辑提示词"
        Me.Editor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Editor.UseAccentColor = False
        Me.Editor.UseVisualStyleBackColor = True
        '
        'IPBox
        '
        Me.IPBox.Location = New System.Drawing.Point(996, 1260)
        Me.IPBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IPBox.Name = "IPBox"
        Me.IPBox.Size = New System.Drawing.Size(190, 28)
        Me.IPBox.TabIndex = 41
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(996, 1296)
        Me.PortBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(190, 28)
        Me.PortBox.TabIndex = 42
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1840, 2031)
        Me.Controls.Add(Me.TextStatus)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.IPBox)
        Me.Controls.Add(Me.Editor)
        Me.Controls.Add(Me.CheckLog)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.logData)
        Me.Controls.Add(Me.para)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.ActionBar)
        Me.Controls.Add(Me.Launch)
        Me.Controls.Add(Me.GroupGPTVersion)
        Me.DrawerWidth = 400
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(4, 39, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数字生命"
        Me.GroupGPTVersion.ResumeLayout(False)
        Me.GroupGPTVersion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupGPTVersion As GroupBox
    Friend WithEvents OptionAPI As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents TextAPIKey As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents Launch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ActionBar As Label
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents ComboModSelect As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents para As TextBox
    Friend WithEvents logData As TextBox
    Friend WithEvents Save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextStatus As Label
    Friend WithEvents CheckStream As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents ComboCharacterSelect As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CheckLog As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Editor As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IPBox As TextBox
    Friend WithEvents PortBox As TextBox
    Friend WithEvents TextBaseUrl As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents OptionAnthropic As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents OptionGemini As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents CheckNonEXE As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents CustonModel As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents SysEnvironment As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents CustomModelInput As MaterialSkin.Controls.MaterialMaskedTextBox
End Class
