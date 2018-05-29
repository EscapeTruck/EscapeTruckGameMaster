<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EscapeTruckGameMaster
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
        Me.cmboPuzzleCount = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmboDifficulty = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmboPlayerCount = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DeviceGrid = New System.Windows.Forms.DataGridView()
        Me.DeviceContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._udpListener = New System.ComponentModel.BackgroundWorker()
        Me.DeviceGridName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceGridIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceGridLastSeen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceGridResetBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DeviceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeviceContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmboPuzzleCount
        '
        Me.cmboPuzzleCount.FormattingEnabled = True
        Me.cmboPuzzleCount.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmboPuzzleCount.Location = New System.Drawing.Point(5, 23)
        Me.cmboPuzzleCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmboPuzzleCount.Name = "cmboPuzzleCount"
        Me.cmboPuzzleCount.Size = New System.Drawing.Size(108, 24)
        Me.cmboPuzzleCount.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 10)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 336)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.cmboDifficulty)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmboPlayerCount)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmboPuzzleCount)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(603, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Game Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(479, 271)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Start Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmboDifficulty
        '
        Me.cmboDifficulty.FormattingEnabled = True
        Me.cmboDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cmboDifficulty.Location = New System.Drawing.Point(4, 118)
        Me.cmboDifficulty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmboDifficulty.Name = "cmboDifficulty"
        Me.cmboDifficulty.Size = New System.Drawing.Size(108, 24)
        Me.cmboDifficulty.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Difficulty"
        '
        'cmboPlayerCount
        '
        Me.cmboPlayerCount.FormattingEnabled = True
        Me.cmboPlayerCount.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmboPlayerCount.Location = New System.Drawing.Point(4, 71)
        Me.cmboPlayerCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmboPlayerCount.Name = "cmboPlayerCount"
        Me.cmboPlayerCount.Size = New System.Drawing.Size(108, 24)
        Me.cmboPlayerCount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player Count"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Puzzle Count"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DeviceGrid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(603, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Truck Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DeviceGrid
        '
        Me.DeviceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeviceGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeviceGridName, Me.DeviceGridIP, Me.DeviceGridLastSeen, Me.DeviceGridResetBtn})
        Me.DeviceGrid.Location = New System.Drawing.Point(6, 5)
        Me.DeviceGrid.Name = "DeviceGrid"
        Me.DeviceGrid.RowTemplate.Height = 24
        Me.DeviceGrid.Size = New System.Drawing.Size(591, 297)
        Me.DeviceGrid.TabIndex = 0
        '
        'DeviceContextMenu
        '
        Me.DeviceContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DeviceContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.DeviceContextMenu.Name = "DeviceContextMenu"
        Me.DeviceContextMenu.Size = New System.Drawing.Size(115, 28)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        '_udpListener
        '
        Me._udpListener.WorkerReportsProgress = True
        '
        'DeviceGridName
        '
        Me.DeviceGridName.DataPropertyName = "Name"
        Me.DeviceGridName.HeaderText = "Name"
        Me.DeviceGridName.Name = "DeviceGridName"
        Me.DeviceGridName.ReadOnly = True
        '
        'DeviceGridIP
        '
        Me.DeviceGridIP.DataPropertyName = "IP"
        Me.DeviceGridIP.HeaderText = "IP Address"
        Me.DeviceGridIP.Name = "DeviceGridIP"
        '
        'DeviceGridLastSeen
        '
        Me.DeviceGridLastSeen.DataPropertyName = "LastSeen"
        Me.DeviceGridLastSeen.HeaderText = "Last Seen"
        Me.DeviceGridLastSeen.Name = "DeviceGridLastSeen"
        Me.DeviceGridLastSeen.ReadOnly = True
        '
        'DeviceGridResetBtn
        '
        Me.DeviceGridResetBtn.HeaderText = "Reset"
        Me.DeviceGridResetBtn.Name = "DeviceGridResetBtn"
        Me.DeviceGridResetBtn.Text = "Reset"
        '
        'EscapeTruckGameMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 356)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EscapeTruckGameMaster"
        Me.Text = "Main"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DeviceGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeviceContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmboPuzzleCount As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmboPlayerCount As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmboDifficulty As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents _udpListener As System.ComponentModel.BackgroundWorker
    Friend WithEvents DeviceGrid As DataGridView
    Friend WithEvents DeviceContextMenu As ContextMenuStrip
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceGridName As DataGridViewTextBoxColumn
    Friend WithEvents DeviceGridIP As DataGridViewTextBoxColumn
    Friend WithEvents DeviceGridLastSeen As DataGridViewTextBoxColumn
    Friend WithEvents DeviceGridResetBtn As DataGridViewButtonColumn
End Class
