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
        Me.browser = New DotNetBrowser.WinForms.WinFormsBrowserView()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSubmitGuess = New System.Windows.Forms.Button()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'browser
        '
        Me.browser.AcceptLanguage = Nothing
        Me.browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browser.AudioMuted = Nothing
        Me.browser.BrowserType = DotNetBrowser.BrowserType.HEAVYWEIGHT
        Me.browser.Location = New System.Drawing.Point(13, 13)
        Me.browser.Name = "browser"
        Me.browser.Preferences = Nothing
        Me.browser.Size = New System.Drawing.Size(943, 625)
        Me.browser.TabIndex = 0
        Me.browser.URL = Nothing
        Me.browser.ZoomLevel = Nothing
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(962, 55)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(226, 26)
        Me.txtInput.TabIndex = 1
        '
        'btnSubmitGuess
        '
        Me.btnSubmitGuess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitGuess.Location = New System.Drawing.Point(962, 99)
        Me.btnSubmitGuess.Name = "btnSubmitGuess"
        Me.btnSubmitGuess.Size = New System.Drawing.Size(226, 44)
        Me.btnSubmitGuess.TabIndex = 2
        Me.btnSubmitGuess.Text = "Button1"
        Me.btnSubmitGuess.UseVisualStyleBackColor = True
        '
        'btnCloseForm
        '
        Me.btnCloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseForm.Location = New System.Drawing.Point(962, 601)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(226, 37)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.Text = "Button1"
        Me.btnCloseForm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnSubmitGuess)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.browser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents browser As DotNetBrowser.WinForms.WinFormsBrowserView
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnSubmitGuess As Button
    Friend WithEvents btnCloseForm As Button
End Class
