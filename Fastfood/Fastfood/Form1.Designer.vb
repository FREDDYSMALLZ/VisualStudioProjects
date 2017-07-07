<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliseFood
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSandwich = New System.Windows.Forms.GroupBox()
        Me.radNoSandwich = New System.Windows.Forms.RadioButton()
        Me.radHumberger = New System.Windows.Forms.RadioButton()
        Me.radFishSandwich = New System.Windows.Forms.RadioButton()
        Me.radChickenSandwich = New System.Windows.Forms.RadioButton()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkTomatoes = New System.Windows.Forms.CheckBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radNoDrink = New System.Windows.Forms.RadioButton()
        Me.radCola = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.radOrange = New System.Windows.Forms.RadioButton()
        Me.radRootBeer = New System.Windows.Forms.RadioButton()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkOnionRings = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.lstOrderReceipt = New System.Windows.Forms.ListBox()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.grpSandwich.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(727, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elise's Fast Food Restaurant"
        '
        'grpSandwich
        '
        Me.grpSandwich.BackColor = System.Drawing.Color.Chocolate
        Me.grpSandwich.Controls.Add(Me.chkTomatoes)
        Me.grpSandwich.Controls.Add(Me.chkCheese)
        Me.grpSandwich.Controls.Add(Me.radChickenSandwich)
        Me.grpSandwich.Controls.Add(Me.radFishSandwich)
        Me.grpSandwich.Controls.Add(Me.radHumberger)
        Me.grpSandwich.Controls.Add(Me.radNoSandwich)
        Me.grpSandwich.Location = New System.Drawing.Point(97, 212)
        Me.grpSandwich.Name = "grpSandwich"
        Me.grpSandwich.Size = New System.Drawing.Size(405, 450)
        Me.grpSandwich.TabIndex = 1
        Me.grpSandwich.TabStop = False
        Me.grpSandwich.Text = "Sand Wich"
        '
        'radNoSandwich
        '
        Me.radNoSandwich.AutoSize = True
        Me.radNoSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoSandwich.Location = New System.Drawing.Point(7, 49)
        Me.radNoSandwich.Name = "radNoSandwich"
        Me.radNoSandwich.Size = New System.Drawing.Size(125, 41)
        Me.radNoSandwich.TabIndex = 0
        Me.radNoSandwich.TabStop = True
        Me.radNoSandwich.Text = "None"
        Me.radNoSandwich.UseVisualStyleBackColor = True
        '
        'radHumberger
        '
        Me.radHumberger.AutoSize = True
        Me.radHumberger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHumberger.Location = New System.Drawing.Point(7, 102)
        Me.radHumberger.Name = "radHumberger"
        Me.radHumberger.Size = New System.Drawing.Size(298, 41)
        Me.radHumberger.TabIndex = 1
        Me.radHumberger.TabStop = True
        Me.radHumberger.Text = "$2.75 Humberger"
        Me.radHumberger.UseVisualStyleBackColor = True
        '
        'radFishSandwich
        '
        Me.radFishSandwich.AutoSize = True
        Me.radFishSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFishSandwich.Location = New System.Drawing.Point(7, 155)
        Me.radFishSandwich.Name = "radFishSandwich"
        Me.radFishSandwich.Size = New System.Drawing.Size(347, 41)
        Me.radFishSandwich.TabIndex = 2
        Me.radFishSandwich.TabStop = True
        Me.radFishSandwich.Text = "$3.25 Fish Sandwich"
        Me.radFishSandwich.UseVisualStyleBackColor = True
        '
        'radChickenSandwich
        '
        Me.radChickenSandwich.AutoSize = True
        Me.radChickenSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChickenSandwich.Location = New System.Drawing.Point(7, 202)
        Me.radChickenSandwich.Name = "radChickenSandwich"
        Me.radChickenSandwich.Size = New System.Drawing.Size(401, 41)
        Me.radChickenSandwich.TabIndex = 3
        Me.radChickenSandwich.TabStop = True
        Me.radChickenSandwich.Text = "$2.49 Chicken Sandwich"
        Me.radChickenSandwich.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.Location = New System.Drawing.Point(7, 251)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(245, 41)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "$0.10 Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkTomatoes
        '
        Me.chkTomatoes.AutoSize = True
        Me.chkTomatoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTomatoes.Location = New System.Drawing.Point(7, 299)
        Me.chkTomatoes.Name = "chkTomatoes"
        Me.chkTomatoes.Size = New System.Drawing.Size(282, 41)
        Me.chkTomatoes.TabIndex = 5
        Me.chkTomatoes.Text = "$0.20 Tomatoes"
        Me.chkTomatoes.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(154, 713)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(232, 88)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(154, 851)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(232, 88)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(154, 982)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(232, 88)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.BackColor = System.Drawing.Color.Olive
        Me.grpDrinks.Controls.Add(Me.radRootBeer)
        Me.grpDrinks.Controls.Add(Me.radOrange)
        Me.grpDrinks.Controls.Add(Me.RadioButton7)
        Me.grpDrinks.Controls.Add(Me.radCola)
        Me.grpDrinks.Controls.Add(Me.radNoDrink)
        Me.grpDrinks.Location = New System.Drawing.Point(530, 212)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(374, 259)
        Me.grpDrinks.TabIndex = 3
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "$0.25 Drinks"
        '
        'radNoDrink
        '
        Me.radNoDrink.AutoSize = True
        Me.radNoDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoDrink.Location = New System.Drawing.Point(20, 60)
        Me.radNoDrink.Name = "radNoDrink"
        Me.radNoDrink.Size = New System.Drawing.Size(125, 41)
        Me.radNoDrink.TabIndex = 0
        Me.radNoDrink.TabStop = True
        Me.radNoDrink.Text = "None"
        Me.radNoDrink.UseVisualStyleBackColor = True
        '
        'radCola
        '
        Me.radCola.AutoSize = True
        Me.radCola.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCola.Location = New System.Drawing.Point(20, 107)
        Me.radCola.Name = "radCola"
        Me.radCola.Size = New System.Drawing.Size(114, 41)
        Me.radCola.TabIndex = 0
        Me.radCola.TabStop = True
        Me.radCola.Text = "Cola"
        Me.radCola.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(31, 155)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(114, 41)
        Me.RadioButton7.TabIndex = 0
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Cola"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'radOrange
        '
        Me.radOrange.AutoSize = True
        Me.radOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrange.Location = New System.Drawing.Point(20, 155)
        Me.radOrange.Name = "radOrange"
        Me.radOrange.Size = New System.Drawing.Size(155, 41)
        Me.radOrange.TabIndex = 0
        Me.radOrange.TabStop = True
        Me.radOrange.Text = "Orange"
        Me.radOrange.UseVisualStyleBackColor = True
        '
        'radRootBeer
        '
        Me.radRootBeer.AutoSize = True
        Me.radRootBeer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRootBeer.Location = New System.Drawing.Point(20, 202)
        Me.radRootBeer.Name = "radRootBeer"
        Me.radRootBeer.Size = New System.Drawing.Size(190, 41)
        Me.radRootBeer.TabIndex = 0
        Me.radRootBeer.TabStop = True
        Me.radRootBeer.Text = "Root Beer"
        Me.radRootBeer.UseVisualStyleBackColor = True
        '
        'grpExtras
        '
        Me.grpExtras.BackColor = System.Drawing.Color.Gold
        Me.grpExtras.Controls.Add(Me.chkFries)
        Me.grpExtras.Controls.Add(Me.chkOnionRings)
        Me.grpExtras.Location = New System.Drawing.Point(530, 497)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(374, 165)
        Me.grpExtras.TabIndex = 4
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'chkOnionRings
        '
        Me.chkOnionRings.AutoSize = True
        Me.chkOnionRings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnionRings.Location = New System.Drawing.Point(20, 54)
        Me.chkOnionRings.Name = "chkOnionRings"
        Me.chkOnionRings.Size = New System.Drawing.Size(315, 41)
        Me.chkOnionRings.TabIndex = 0
        Me.chkOnionRings.Text = "$2.30 Onion Rings"
        Me.chkOnionRings.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFries.Location = New System.Drawing.Point(20, 101)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(208, 41)
        Me.chkFries.TabIndex = 0
        Me.chkFries.Text = "$1.29 Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'lstOrderReceipt
        '
        Me.lstOrderReceipt.FormattingEnabled = True
        Me.lstOrderReceipt.ItemHeight = 42
        Me.lstOrderReceipt.Location = New System.Drawing.Point(530, 713)
        Me.lstOrderReceipt.Name = "lstOrderReceipt"
        Me.lstOrderReceipt.Size = New System.Drawing.Size(374, 172)
        Me.lstOrderReceipt.TabIndex = 5
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.ItemHeight = 42
        Me.lstTotal.Location = New System.Drawing.Point(530, 898)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(374, 172)
        Me.lstTotal.TabIndex = 5
        '
        'frmEliseFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(23.0!, 42.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(949, 1084)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lstOrderReceipt)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grpSandwich)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "frmEliseFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elise's Fast Food Restaurant"
        Me.grpSandwich.ResumeLayout(False)
        Me.grpSandwich.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpSandwich As GroupBox
    Friend WithEvents chkTomatoes As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents radChickenSandwich As RadioButton
    Friend WithEvents radFishSandwich As RadioButton
    Friend WithEvents radHumberger As RadioButton
    Friend WithEvents radNoSandwich As RadioButton
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents radRootBeer As RadioButton
    Friend WithEvents radOrange As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents radCola As RadioButton
    Friend WithEvents radNoDrink As RadioButton
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkOnionRings As CheckBox
    Friend WithEvents lstOrderReceipt As ListBox
    Friend WithEvents lstTotal As ListBox
End Class
