<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sansyou
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
        Button1 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Radio2 = New RadioButton()
        Radio1 = New RadioButton()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Location = New Point(21, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 62)
        Button1.TabIndex = 0
        Button1.Text = "メイン画面へ戻る"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("メイリオ", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(695, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 54)
        Label1.TabIndex = 1
        Label1.Text = "顧客参照画面"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 219)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1570, 446)
        DataGridView1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Location = New Point(1444, 139)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 51)
        Button2.TabIndex = 3
        Button2.Text = "詳細検索"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Radio2)
        Panel1.Controls.Add(Radio1)
        Panel1.Location = New Point(22, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 96)
        Panel1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("メイリオ", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(25, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 42)
        Label2.TabIndex = 2
        Label2.Text = "顧客番号"
        ' 
        ' Radio2
        ' 
        Radio2.Anchor = AnchorStyles.None
        Radio2.AutoSize = True
        Radio2.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Radio2.Location = New Point(192, 49)
        Radio2.Name = "Radio2"
        Radio2.Size = New Size(88, 40)
        Radio2.TabIndex = 1
        Radio2.TabStop = True
        Radio2.Text = "降順"
        Radio2.UseVisualStyleBackColor = True
        ' 
        ' Radio1
        ' 
        Radio1.Anchor = AnchorStyles.None
        Radio1.AutoSize = True
        Radio1.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Radio1.Location = New Point(192, 3)
        Radio1.Name = "Radio1"
        Radio1.Size = New Size(88, 40)
        Radio1.TabIndex = 0
        Radio1.TabStop = True
        Radio1.Text = "昇順"
        Radio1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Location = New Point(888, 671)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 53)
        Button3.TabIndex = 5
        Button3.Text = "次へ"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.Location = New Point(622, 671)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 53)
        Button4.TabIndex = 6
        Button4.Text = "前へ"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(828, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(599, 31)
        TextBox1.TabIndex = 7
        ' 
        ' Sansyou
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1603, 738)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Sansyou"
        Text = "Sansyou"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Radio2 As RadioButton
    Friend WithEvents Radio1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
