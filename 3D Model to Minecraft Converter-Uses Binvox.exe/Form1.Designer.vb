<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.selectFileBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.voxlGrdSizeNumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.rotDegreesX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rotDegreesZ = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exactVoxlChckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.specifyVoxlGrdSizChckBox = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.commandTxtBoxUpdator = New System.Windows.Forms.Timer(Me.components)
        Me.cmdOutPutTxtBox = New System.Windows.Forms.TextBox()
        Me.voxelGridSizeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rotLX = New System.Windows.Forms.Button()
        Me.rotRX = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rotLZ = New System.Windows.Forms.Button()
        Me.rotRZ = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.voxlGrdSizeNumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.selectFileBtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select 3D Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Drag the file into the ""3D_Models"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder and then select it"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(21, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Please select a file"
        '
        'selectFileBtn
        '
        Me.selectFileBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.selectFileBtn.Location = New System.Drawing.Point(63, 54)
        Me.selectFileBtn.Name = "selectFileBtn"
        Me.selectFileBtn.Size = New System.Drawing.Size(72, 23)
        Me.selectFileBtn.TabIndex = 2
        Me.selectFileBtn.Text = "Select File..."
        Me.selectFileBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "OBJ, OFF, DXF, XGL, POV," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BREP, PLY, JOT files supported!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.voxlGrdSizeNumUpDown)
        Me.GroupBox2.Controls.Add(Me.rotLX)
        Me.GroupBox2.Controls.Add(Me.rotRX)
        Me.GroupBox2.Controls.Add(Me.rotDegreesX)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.rotLZ)
        Me.GroupBox2.Controls.Add(Me.rotRZ)
        Me.GroupBox2.Controls.Add(Me.rotDegreesZ)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.exactVoxlChckBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.specifyVoxlGrdSizChckBox)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 156)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'voxlGrdSizeNumUpDown
        '
        Me.voxlGrdSizeNumUpDown.Enabled = False
        Me.voxlGrdSizeNumUpDown.Location = New System.Drawing.Point(94, 41)
        Me.voxlGrdSizeNumUpDown.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.voxlGrdSizeNumUpDown.Name = "voxlGrdSizeNumUpDown"
        Me.voxlGrdSizeNumUpDown.Size = New System.Drawing.Size(58, 20)
        Me.voxlGrdSizeNumUpDown.TabIndex = 1
        Me.voxlGrdSizeNumUpDown.Value = New Decimal(New Integer() {124, 0, 0, 0})
        '
        'rotDegreesX
        '
        Me.rotDegreesX.Location = New System.Drawing.Point(104, 117)
        Me.rotDegreesX.Name = "rotDegreesX"
        Me.rotDegreesX.ReadOnly = True
        Me.rotDegreesX.Size = New System.Drawing.Size(69, 20)
        Me.rotDegreesX.TabIndex = 15
        Me.rotDegreesX.Text = "0 degrees"
        Me.rotDegreesX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Rotate X Axis:"
        '
        'rotDegreesZ
        '
        Me.rotDegreesZ.Location = New System.Drawing.Point(104, 88)
        Me.rotDegreesZ.Name = "rotDegreesZ"
        Me.rotDegreesZ.ReadOnly = True
        Me.rotDegreesZ.Size = New System.Drawing.Size(69, 20)
        Me.rotDegreesZ.TabIndex = 11
        Me.rotDegreesZ.Text = "0 degrees"
        Me.rotDegreesZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rotate Z Axis:"
        '
        'exactVoxlChckBox
        '
        Me.exactVoxlChckBox.AutoSize = True
        Me.exactVoxlChckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exactVoxlChckBox.Location = New System.Drawing.Point(6, 66)
        Me.exactVoxlChckBox.Name = "exactVoxlChckBox"
        Me.exactVoxlChckBox.Size = New System.Drawing.Size(118, 18)
        Me.exactVoxlChckBox.TabIndex = 8
        Me.exactVoxlChckBox.Text = "Exact Voxelization"
        Me.exactVoxlChckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Block Type:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Stone", "Granite", "Polished Granite", "Diorite", "Polished Diorite", "Andesite", "Polished Andesite", "Grass", "Dirt", "Cobblestone", "Oak Wood Plank", "Spruce Wood Plank", "Birch Wood Plank", "Jungle Wood Plank", "Acacia Wood Plank", "Dark Oak Wood Plank", "Bedrock", "Still Water", "Still Lava", "Sand", "Red Sand", "Gravel", "Gold Ore", "Iron Ore", "Coal Ore", "Oak Wood", "Spruce Wood", "Birch Wood", "Jungle Wood", "Oak Leaves", "Spruce Leaves", "Birch Leaves", "Jungle Leaves", "Sponge", "Lapis Lazuli Ore", "Lapis Lazuli Block", "Dispenser", "Sandstone", "Chiseled Sandstone", "Smooth Sandstone", "Note Block", "Sticky Piston", "Cobweb", "Piston", "White Wool", "Orange Wool", "Magenta Wool", "Light Blue Wool", "Yellow Wool", "Lime Wool", "Pink Wool", "Gray Wool", "Light Gray Wool", "Cyan Wool", "Purple Wool", "Blue Wool", "Brown Wool", "Green Wool", "Red Wool", "Black Wool", "Gold Block", "Iron Block", "Double Stone Slab", "Stone Slab", "Bricks", "TNT", "Bookshelf", "Moss Stone", "Obsidian", "Monster Spawner", "Oak Wood Stairs", "Chest", "Diamond Ore", "Diamond Block", "Crafting Table", "Furnace", "Cobblestone Stairs", "Redstone Ore", "Ice", "Snow Block", "Clay", "Jukebox", "Oak Fence", "Pumpkin", "Netherrack", "Soul Sand", "Glowstone", "White Stained Glass", "Orange Stained Glass", "Magenta Stained Glass", "Light Blue Stained Glass", "Yellow Stained Glass", "Lime Stained Glass", "Pink Stained Glass", "Gray Stained Glass", "Light Gray Stained Glass", "Cyan Stained Glass", "Purple Stained Glass", "Blue Stained Glass", "Brown Stained Glass", "Green Stained Glass", "Red Stained Glass", "Black Stained Glass", "Stone Monster Egg", "Cobblestone Monster Egg", "Stone Brick Monster Egg", "Mossy Stone Brick Monster Egg", "Cracked Stone Brick Monster Egg", "Chiseled Stone Brick Monster Egg", "Stone Bricks", "Mossy Stone Bricks", "Cracked Stone Bricks", "Chiseled Stone Bricks", "Brown Mushroom Block", "Red Mushroom Block", "Iron Bars", "Glass Pane", "Melon Block", "Brick Stairs", "Stone Brick Stairs", "Mycelium", "Nether Brick", "Nether Brick Fence", "Nether Brick Stairs", "End Stone", "Redstone Lamp", "Oak Wood Slab", "Sandstone Stairs", "Emerald Ore", "Ender Chest", "Emerald Block", "Spruce Wood Stairs", "Birch Wood Stairs", "Jungle Wood Stairs", "Command Block", "Beacon", "Cobblestone Wall", "Redstone Block", "Nether Quartz Ore", "Quartz Block", "Chiseled Quartz Block", "Pillar Quartz Block", "Quartz Stairs", "Dropper", "White Hardened Clay", "Orange Hardened Clay", "Magenta Hardened Clay", "Light Blue Hardened Clay", "Yellow Hardened Clay", "Lime Hardened Clay", "Pink Hardened Clay", "Gray Hardened Clay", "Light Gray Hardened Clay", "Cyan Hardened Clay", "Purple Hardened Clay", "Blue Hardened Clay", "Brown Hardened Clay", "Green Hardened Clay", "Red Hardened Clay", "Black Hardened Clay", "Acacia Leaves", "Dark Oak Leaves", "Acacia Wood", "Dark Oak Wood", "Acacia Wood Stairs", "Dark Oak Wood Stairs", "Slime Block", "Barrier", "Prismarine", "Sea Lantern", "Hay Bale", "Hardened Clay", "Block of Coal", "Red Sandstone", "Red Sandstone Stairs", "Red Sandstone Slab"})
        Me.ComboBox1.Location = New System.Drawing.Point(206, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "Stone"
        '
        'specifyVoxlGrdSizChckBox
        '
        Me.specifyVoxlGrdSizChckBox.AutoSize = True
        Me.specifyVoxlGrdSizChckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.specifyVoxlGrdSizChckBox.Location = New System.Drawing.Point(6, 42)
        Me.specifyVoxlGrdSizChckBox.Name = "specifyVoxlGrdSizChckBox"
        Me.specifyVoxlGrdSizChckBox.Size = New System.Drawing.Size(102, 18)
        Me.specifyVoxlGrdSizChckBox.TabIndex = 2
        Me.specifyVoxlGrdSizChckBox.Text = "Voxel grid size:"
        Me.specifyVoxlGrdSizChckBox.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(145, 18)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Remove Internal Blocks"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.convertBtn)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 112)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONVERT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "The file will be exported in the ""3D_Models""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder with .SCHEMATIC format"
        '
        'convertBtn
        '
        Me.convertBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.convertBtn.BackColor = System.Drawing.Color.Transparent
        Me.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.convertBtn.Location = New System.Drawing.Point(78, 67)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(72, 23)
        Me.convertBtn.TabIndex = 3
        Me.convertBtn.Text = "CONVERT!"
        Me.convertBtn.UseVisualStyleBackColor = False
        '
        'commandTxtBoxUpdator
        '
        Me.commandTxtBoxUpdator.Interval = 800
        '
        'cmdOutPutTxtBox
        '
        Me.cmdOutPutTxtBox.BackColor = System.Drawing.Color.White
        Me.cmdOutPutTxtBox.Location = New System.Drawing.Point(238, 174)
        Me.cmdOutPutTxtBox.Multiline = True
        Me.cmdOutPutTxtBox.Name = "cmdOutPutTxtBox"
        Me.cmdOutPutTxtBox.ReadOnly = True
        Me.cmdOutPutTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cmdOutPutTxtBox.Size = New System.Drawing.Size(311, 105)
        Me.cmdOutPutTxtBox.TabIndex = 6
        Me.cmdOutPutTxtBox.Text = ":::::::::::::::::::CONVERTER CONSOLE OUTPUT::::::::::::::::::"
        '
        'voxelGridSizeToolTip
        '
        Me.voxelGridSizeToolTip.AutoPopDelay = 9000
        Me.voxelGridSizeToolTip.InitialDelay = 500
        Me.voxelGridSizeToolTip.IsBalloon = True
        Me.voxelGridSizeToolTip.ReshowDelay = 100
        Me.voxelGridSizeToolTip.ToolTipTitle = "Info"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(225, 282)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Youtube Channel"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(48, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(206, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        Me.voxelGridSizeToolTip.SetToolTip(Me.PictureBox3, "Rotate your 3D model.")
        '
        'rotLX
        '
        Me.rotLX.Image = Global._3D_Model_to_Minecraft_Converter.My.Resources.Resources.icons8_rotate_24
        Me.rotLX.Location = New System.Drawing.Point(74, 114)
        Me.rotLX.Name = "rotLX"
        Me.rotLX.Size = New System.Drawing.Size(30, 28)
        Me.rotLX.TabIndex = 17
        Me.voxelGridSizeToolTip.SetToolTip(Me.rotLX, "Left")
        Me.rotLX.UseVisualStyleBackColor = True
        '
        'rotRX
        '
        Me.rotRX.Image = Global._3D_Model_to_Minecraft_Converter.My.Resources.Resources.icons8_rotate2_24
        Me.rotRX.Location = New System.Drawing.Point(173, 113)
        Me.rotRX.Name = "rotRX"
        Me.rotRX.Size = New System.Drawing.Size(30, 28)
        Me.rotRX.TabIndex = 16
        Me.voxelGridSizeToolTip.SetToolTip(Me.rotRX, "Right")
        Me.rotRX.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(114, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.voxelGridSizeToolTip.SetToolTip(Me.PictureBox2, "It utilizes a different voxelizing method that uses the CPU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'rotLZ
        '
        Me.rotLZ.Image = Global._3D_Model_to_Minecraft_Converter.My.Resources.Resources.icons8_rotate_24
        Me.rotLZ.Location = New System.Drawing.Point(74, 85)
        Me.rotLZ.Name = "rotLZ"
        Me.rotLZ.Size = New System.Drawing.Size(30, 28)
        Me.rotLZ.TabIndex = 13
        Me.voxelGridSizeToolTip.SetToolTip(Me.rotLZ, "Left")
        Me.rotLZ.UseVisualStyleBackColor = True
        '
        'rotRZ
        '
        Me.rotRZ.Image = Global._3D_Model_to_Minecraft_Converter.My.Resources.Resources.icons8_rotate2_24
        Me.rotRZ.Location = New System.Drawing.Point(173, 84)
        Me.rotRZ.Name = "rotRZ"
        Me.rotRZ.Size = New System.Drawing.Size(30, 28)
        Me.rotRZ.TabIndex = 12
        Me.voxelGridSizeToolTip.SetToolTip(Me.rotRZ, "Right")
        Me.rotRZ.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(154, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.voxelGridSizeToolTip.SetToolTip(Me.PictureBox1, "Specify the size of the 3D Model after conversion. If the structure looks too big" &
        " in minecraft, lower the voxel grid size")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 297)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdOutPutTxtBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "3D Model to Minecraft SCHEMATIC Converter v1.4.1-Uses Binvox.exe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.voxlGrdSizeNumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents convertBtn As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents voxlGrdSizeNumUpDown As NumericUpDown
    Friend WithEvents specifyVoxlGrdSizChckBox As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents commandTxtBoxUpdator As Timer
    Friend WithEvents selectFileBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdOutPutTxtBox As TextBox
    Friend WithEvents voxelGridSizeToolTip As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exactVoxlChckBox As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents rotLZ As Button
    Friend WithEvents rotRZ As Button
    Friend WithEvents rotDegreesZ As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rotLX As Button
    Friend WithEvents rotRX As Button
    Friend WithEvents rotDegreesX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
