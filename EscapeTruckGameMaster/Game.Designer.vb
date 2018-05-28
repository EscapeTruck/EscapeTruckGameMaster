<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.browser = New DotNetBrowser.WinForms.WinFormsBrowserView()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSubmitGuess = New System.Windows.Forms.Button()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
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
        Me.browser.Location = New System.Drawing.Point(12, 57)
        Me.browser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.browser.Name = "browser"
        Me.browser.Preferences = Nothing
        Me.browser.Size = New System.Drawing.Size(802, 544)
        Me.browser.TabIndex = 0
        Me.browser.URL = Nothing
        Me.browser.ZoomLevel = Nothing
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(820, 57)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(201, 22)
        Me.txtInput.TabIndex = 1
        '
        'btnSubmitGuess
        '
        Me.btnSubmitGuess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitGuess.Location = New System.Drawing.Point(821, 83)
        Me.btnSubmitGuess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmitGuess.Name = "btnSubmitGuess"
        Me.btnSubmitGuess.Size = New System.Drawing.Size(201, 35)
        Me.btnSubmitGuess.TabIndex = 2
        Me.btnSubmitGuess.Text = "Submit Guess"
        Me.btnSubmitGuess.UseVisualStyleBackColor = True
        '
        'btnCloseForm
        '
        Me.btnCloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseForm.Location = New System.Drawing.Point(820, 572)
        Me.btnCloseForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(201, 30)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.Text = "Close"
        Me.btnCloseForm.UseVisualStyleBackColor = True
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 10
        '
        'timeLabel
        '
        Me.timeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.timeLabel.Location = New System.Drawing.Point(875, 9)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(145, 46)
        Me.timeLabel.TabIndex = 4
        Me.timeLabel.Text = "Label1"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 9)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(267, 17)
        Me.lblPath.TabIndex = 5
        Me.lblPath.Text = "http://localhost:8080/prod/building_lights/"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(12, 29)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(51, 17)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.Text = "Label1"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 611)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnSubmitGuess)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.browser)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents browser As DotNetBrowser.WinForms.WinFormsBrowserView
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnSubmitGuess As Button
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents tmrGame As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblAnswer As Label
End Class
