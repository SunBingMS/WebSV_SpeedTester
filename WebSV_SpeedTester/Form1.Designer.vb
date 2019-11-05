<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedTester
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpeedTester))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSQL = New System.Windows.Forms.RichTextBox()
        Me.lblSQL_t = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblCount_t = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.starttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(12, 31)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(335, 288)
        Me.txtSQL.TabIndex = 1
        Me.txtSQL.Text = resources.GetString("txtSQL.Text")
        '
        'lblSQL_t
        '
        Me.lblSQL_t.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSQL_t.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lblSQL_t.ForeColor = System.Drawing.Color.White
        Me.lblSQL_t.Location = New System.Drawing.Point(12, 9)
        Me.lblSQL_t.Name = "lblSQL_t"
        Me.lblSQL_t.Padding = New System.Windows.Forms.Padding(3)
        Me.lblSQL_t.Size = New System.Drawing.Size(334, 22)
        Me.lblSQL_t.TabIndex = 1
        Me.lblSQL_t.Text = "実行したいＳＱＬ文を記入してください"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(171, 325)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(175, 44)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "実行"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblCount_t
        '
        Me.lblCount_t.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCount_t.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lblCount_t.ForeColor = System.Drawing.Color.White
        Me.lblCount_t.Location = New System.Drawing.Point(12, 325)
        Me.lblCount_t.Name = "lblCount_t"
        Me.lblCount_t.Padding = New System.Windows.Forms.Padding(3)
        Me.lblCount_t.Size = New System.Drawing.Size(153, 22)
        Me.lblCount_t.TabIndex = 1
        Me.lblCount_t.Text = "実行回数"
        Me.lblCount_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.txtCount.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtCount.Location = New System.Drawing.Point(12, 347)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(153, 22)
        Me.txtCount.TabIndex = 2
        Me.txtCount.Text = "1"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.AllowUserToOrderColumns = True
        Me.dgvResult.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan
        Me.dgvResult.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.starttime, Me.endtime, Me.ms})
        Me.dgvResult.Location = New System.Drawing.Point(353, 9)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.RowHeadersVisible = False
        Me.dgvResult.RowTemplate.Height = 21
        Me.dgvResult.Size = New System.Drawing.Size(478, 360)
        Me.dgvResult.TabIndex = 6
        Me.dgvResult.TabStop = False
        '
        'seq
        '
        Me.seq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.seq.DefaultCellStyle = DataGridViewCellStyle6
        Me.seq.HeaderText = "№"
        Me.seq.MaxInputLength = 3
        Me.seq.Name = "seq"
        Me.seq.ReadOnly = True
        Me.seq.Width = 50
        '
        'starttime
        '
        Me.starttime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.starttime.HeaderText = "Start時刻"
        Me.starttime.Name = "starttime"
        Me.starttime.ReadOnly = True
        Me.starttime.Width = 150
        '
        'endtime
        '
        Me.endtime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.endtime.HeaderText = "End時刻"
        Me.endtime.Name = "endtime"
        Me.endtime.ReadOnly = True
        Me.endtime.Width = 150
        '
        'ms
        '
        Me.ms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ms.HeaderText = "時間差(s)"
        Me.ms.Name = "ms"
        Me.ms.ReadOnly = True
        '
        'SpeedTester
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(843, 376)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblCount_t)
        Me.Controls.Add(Me.lblSQL_t)
        Me.Controls.Add(Me.txtSQL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SpeedTester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebSV_SpeedTester"
        Me.TopMost = True
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQL As System.Windows.Forms.RichTextBox
    Friend WithEvents lblSQL_t As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblCount_t As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents seq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents starttime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endtime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ms As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
