Imports System.IO
Imports System.Threading

Public Class PromptEditor
    Dim currentFile As String
    Private Sub PromptEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 840
        If Login.ComboModSelect.Text.Contains("gpt") Then
            ActionBar.Text = " 提示词编辑器 " & Login.ComboCharacterSelect.Text & "/" & Login.ComboModSelect.Text
            currentFile = Login.ComboCharacterSelect.Text & "GPT.txt"
            PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
        Else

            If Login.ComboModSelect.Text.Contains("deepseek") Then
                ActionBar.Text = " 提示词编辑器 " & Login.ComboCharacterSelect.Text & "/" & Login.ComboModSelect.Text
                currentFile = Login.ComboCharacterSelect.Text & "ds.txt"
                PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
            Else
                PromptTextBox.Text = "未找到提示词"
            End If
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        File.WriteAllText("GPT\prompts\" & currentFile, PromptTextBox.Text)
        Msgbox2(Me, "成功", "已保存！点击确定关闭窗口",, False, )
        Close()
    End Sub

    Sub Startcopy()
        Shell("cmd /c del GPT\prompts\" & currentFile, vbHide)
        Shell("cmd /c copy GPT\prompts_default\" & currentFile & " " & "GPT\prompts\" & currentFile)
        Thread.Sleep(1500)
        PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
    End Sub

    Private Sub PromptTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromptTextBox.TextChanged

    End Sub
End Class