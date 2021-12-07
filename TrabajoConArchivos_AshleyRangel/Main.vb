Imports System
Imports System.IO
Public Class Main
    Dim strTexto As String
    Dim strNombreArchivo As String
    Dim pathFileName As String
    Dim bCambio As Boolean
    Dim zoom As Single
    Public Sub CambioControles()
        tsBtnNuevo.Enabled = Not tsBtnNuevo.Enabled
        tsBtnAbrir.Enabled = Not tsBtnAbrir.Enabled
        tsBtnGuardar.Enabled = Not tsBtnGuardar.Enabled
        tsBtnGuardarComo.Enabled = Not tsBtnGuardarComo.Enabled
        tsBtnSalir.Enabled = Not tsBtnSalir.Enabled
        tsBtnDeshacer.Enabled = Not tsBtnDeshacer.Enabled
        tsBtnCerrar.Enabled = Not tsBtnCerrar.Enabled
        tsBtnCortar.Enabled = Not tsBtnCortar.Enabled
        tsBtnCopiar.Enabled = Not tsBtnCopiar.Enabled
        tsBtnPegar.Enabled = Not tsBtnPegar.Enabled
        tsBtnIzquierda.Enabled = Not tsBtnIzquierda.Enabled
        tsBtnCentrar.Enabled = Not tsBtnCentrar.Enabled
        tsBtnDerecha.Enabled = Not tsBtnDerecha.Enabled
        tsBtnFonts.Enabled = Not tsBtnFonts.Enabled
        tsBtnColor.Enabled = Not tsBtnColor.Enabled
        tsBtnZoom.Enabled = Not tsBtnZoom.Enabled
        NuevoToolStripMenuItem.Enabled = Not NuevoToolStripMenuItem.Enabled
        subMenuAbrir.Enabled = Not subMenuAbrir.Enabled
        subMenuGuardar.Enabled = Not subMenuGuardar.Enabled
        subMenuGuardarComo.Enabled = Not subMenuGuardarComo.Enabled
        subMenuCerrar.Enabled = Not subMenuCerrar.Enabled
        subMenuSalir.Enabled = Not subMenuSalir.Enabled
        DeshacerToolStripMenuItem.Enabled = Not DeshacerToolStripMenuItem.Enabled
        CortarToolStripMenuItem.Enabled = Not CortarToolStripMenuItem.Enabled
        CopiarToolStripMenuItem.Enabled = Not CopiarToolStripMenuItem.Enabled
        PegarToolStripMenuItem.Enabled = Not PegarToolStripMenuItem.Enabled
        SeleccionarTodoToolStripMenuItem.Enabled = Not SeleccionarTodoToolStripMenuItem.Enabled
        BuscarToolStripMenuItem.Enabled = Not BuscarToolStripMenuItem.Enabled
        InsertarImagenDesdeArchivoToolStripMenuItem.Enabled = Not InsertarImagenDesdeArchivoToolStripMenuItem.Enabled
        ZoomAcercarToolStripMenuItem.Enabled = Not ZoomAcercarToolStripMenuItem.Enabled
        ZoomAlejarToolStripMenuItem.Enabled = Not ZoomAlejarToolStripMenuItem.Enabled
        AlinearALaIzquierdaToolStripMenuItem.Enabled = Not AlinearALaIzquierdaToolStripMenuItem.Enabled
        AlinearALaDerechaToolStripMenuItem.Enabled = Not AlinearALaDerechaToolStripMenuItem.Enabled
        AlinearAlCentroToolStripMenuItem.Enabled = Not AlinearAlCentroToolStripMenuItem.Enabled
        AlinearToolStripMenuItem.Enabled = Not AlinearToolStripMenuItem.Enabled
        CambiarColorDeFondoToolStripMenuItem.Enabled = Not CambiarColorDeFondoToolStripMenuItem.Enabled
        CambiarFuenteToolStripMenuItem.Enabled = Not CambiarFuenteToolStripMenuItem.Enabled
        controlRTF.ReadOnly = Not controlRTF.ReadOnly
    End Sub

    'Aumentar el Zoom
    Private Sub AumentoZoom()
        If controlRTF.TextLength > 0 Then
            If zoom < 7 And zoom > 0.49 Then zoom = zoom + 0.5
            controlRTF.ZoomFactor = zoom
        End If
    End Sub

    'Disminuir el Zoom
    Private Sub DisminuyoZoom()
        If controlRTF.TextLength > 0 Then
            If zoom < 7 And zoom > 0.5 Then zoom = zoom - 0.5
            controlRTF.ZoomFactor = zoom
        End If
    End Sub

    'Recuento de caracteres de nuestro documento
    Sub cuentoCaracteres()
        Dim T As Long = Trim(controlRTF.TextLength)
        stLabelCaracteres.Text = “Caracteres: “ & T
    End Sub

    Private Sub alinearIzquierda()
        controlRTF.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub alinearCentro()
        controlRTF.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub alinearDerecha()
        controlRTF.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Public Sub cargoFuentes()
        FontDG.Font = controlRTF.SelectionFont
        FontDG.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            controlRTF.SelectionFont = FontDG.Font
        End If
    End Sub

    Public Sub ColorDeFuente()
        ColorDG.AllowFullOpen = True
        ColorDG.Color = controlRTF.SelectionColor
        ColorDG.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            controlRTF.SelectionColor = ColorDG.Color
        End If
    End Sub

    Public Sub AbrirDocumento()
        If Trim(Me.controlRTF.Text) = “” Then
            With OpenDG
                .Title = “Abrir documento”
                .FileName = “”
                .FilterIndex = 0
                .Filter = “Archivos RTF | *.rtf|Archivos de texto | *.txt”
                .CheckFileExists = True
                .ShowDialog()
            End With
            If Windows.Forms.DialogResult.OK Then
                If OpenDG.FileName <> “” Then controlRTF.LoadFile(OpenDG.FileName)
                pathFileName = OpenDG.FileName
                Me.Text = "Enchulador de texto v1.0 - " + pathFileName
                If controlRTF.Visible = False Then controlRTF.Visible = True
                CambioControles()
                stLabel.Text = pathFileName
            End If
        End If
    End Sub

    Public Sub GuardarDocumento()
        If pathFileName <> “” Then
            controlRTF.SaveFile(pathFileName)
            Exit Sub
        Else
            With SaveDG
                .Filter = “Archivos RTF | *.rtf|Archivos de texto | *.txt”
                .FilterIndex = 0
                .CheckPathExists = True
                .ShowDialog()
            End With
        End If
        If Windows.Forms.DialogResult.OK Then
            If SaveDG.FileName <> “” Then
                controlRTF.SaveFile(SaveDG.FileName)
                pathFileName = SaveDG.FileName
                bCambio = False
                Me.Text = "Enchulador de texto v1.0 - " + pathFileName
            End If
        End If
    End Sub

    Public Sub GuardarDocumentoComo()
        SaveDG.Title = “Guardar documento como”
        GuardarDocumento()
        SaveDG.Title = “Guardar documento”
    End Sub

    Public Sub nuevoDocumento()
        If controlRTF.TextLength <> 0 And pathFileName = “” Or bCambio Then
            Dim msg = “¿Desea guardar el Documento actual?”
            If MessageBox.Show(msg, “Guardar documento”, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                GuardarDocumento()
            End If
        End If
        pathFileName = “”
        Me.Text = "Enchulador de texto v1.0 - Nuevo Documento"
        controlRTF.ResetText()
        CambioControles()
        'controlRTF.ReadOnly = False
        controlRTF.Visible = True
        controlRTF.Focus()
        'tsBtnAbrir.Enabled = True
    End Sub

    Public Sub CerrarDocumento()
        If pathFileName <> “” Then
            controlRTF.SaveFile(pathFileName)
        ElseIf bCambio And pathFileName = “” Then
            GuardarDocumento()
        End If
        controlRTF.Text = “”
        pathFileName = “”
        Me.Text = "Enchulador de texto v1.0"
        bCambio = False
        CambioControles()
    End Sub

    Public Sub insertarImagen()
        With OpenDG
            .Title = “Insertar imagen”
            .FileName = “”
            .Filter = “Imagen JPG | *.jpg|Imagen Gif | *.gif”
            .ShowDialog()
        End With
        If Windows.Forms.DialogResult.OK Then
            If OpenDG.FileName <> “” Then
                Clipboard.SetImage(Image.FromFile(OpenDG.FileName))
                controlRTF.Paste()
            End If
        End If
    End Sub

    Private Sub subMenuAbrir_Click(sender As Object, e As EventArgs) Handles subMenuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub subMenuCerrar_Click(sender As Object, e As EventArgs) Handles subMenuCerrar.Click
        CerrarDocumento()
    End Sub

    Private Sub subMenuGuardar_Click(sender As Object, e As EventArgs) Handles subMenuGuardar.Click
        GuardarDocumento()
    End Sub

    Private Sub subMenuSalir_Click(sender As Object, e As EventArgs) Handles subMenuSalir.Click
        Me.Close()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim i As Long, j As Long
        Dim strCadena As String = InputBox(“Ingrese la cadena de texto a buscar:”, “Búsqueda de
        texto”, "")

        If strCadena = “” Then Exit Sub
        i = 1
        j = Len(strCadena)
        strTexto = Trim(controlRTF.Text)
        For i = 1 To controlRTF.TextLength
            If Mid(strTexto, i, j) = Trim(strCadena) Then
                controlRTF.SelectionStart = i - 1
                controlRTF.SelectionLength = Len(strCadena)
            End If
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCambio = False
        zoom = 1
    End Sub

    Private Sub controlRTF_TextChanged(sender As Object, e As EventArgs) Handles controlRTF.TextChanged
        cuentoCaracteres()
        bCambio = True
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        nuevoDocumento()
    End Sub

    Private Sub subMenuGuardarComo_Click(sender As Object, e As EventArgs) Handles subMenuGuardarComo.Click
        GuardarDocumentoComo()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        controlRTF.Undo()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        controlRTF.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        controlRTF.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        controlRTF.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        controlRTF.SelectAll()
    End Sub

    Private Sub InsertarImagenDesdeArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarImagenDesdeArchivoToolStripMenuItem.Click
        insertarImagen()
    End Sub

    Private Sub AcercarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercarToolStripMenuItem.Click
        AumentoZoom()
    End Sub

    Private Sub AlejarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlejarToolStripMenuItem.Click
        DisminuyoZoom()
    End Sub

    Private Sub AlinearALaIzquierdaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlinearALaIzquierdaToolStripMenuItem.Click
        alinearIzquierda()
    End Sub

    Private Sub AlinearALaDerechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlinearALaDerechaToolStripMenuItem.Click
        alinearDerecha()
    End Sub

    Private Sub AlinearAlCentroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlinearAlCentroToolStripMenuItem.Click
        alinearCentro()
    End Sub

    Private Sub AlinearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlinearToolStripMenuItem.Click
        ColorDeFuente()
    End Sub

    Private Sub CambiarColorDeFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarColorDeFondoToolStripMenuItem.Click
        ColorDG.AllowFullOpen = True
        ColorDG.Color = controlRTF.SelectionColor
        ColorDG.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            controlRTF.BackColor = ColorDG.Color
        End If
    End Sub

    Private Sub VistaNormalMenuItem_Click(sender As Object, e As EventArgs) Handles VistaNormalMenuItem.Click
        zoom = 1
        If controlRTF.TextLength > 0 Then controlRTF.ZoomFactor = zoom
    End Sub

    Private Sub CambiarFuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFuenteToolStripMenuItem.Click
        cargoFuentes()
    End Sub

    Private Sub tsBtnNuevo_Click(sender As Object, e As EventArgs) Handles tsBtnNuevo.Click
        nuevoDocumento()
    End Sub

    Private Sub tsBtnAbrir_Click(sender As Object, e As EventArgs) Handles tsBtnAbrir.Click
        CambioControles()
        AbrirDocumento()
        controlRTF.Visible = True
        controlRTF.Focus()
    End Sub

    Private Sub tsBtnGuardar_Click(sender As Object, e As EventArgs) Handles tsBtnGuardar.Click
        GuardarDocumento()
    End Sub

    Private Sub tsBtnGuardarComo_Click(sender As Object, e As EventArgs) Handles tsBtnGuardarComo.Click
        GuardarDocumentoComo()
    End Sub

    Private Sub tsBtnCerrar_Click(sender As Object, e As EventArgs) Handles tsBtnCerrar.Click
        CerrarDocumento()
    End Sub

    Private Sub tsBtnSalir_Click(sender As Object, e As EventArgs) Handles tsBtnSalir.Click
        Me.Close()
    End Sub

    Private Sub tsBtnDeshacer_Click(sender As Object, e As EventArgs) Handles tsBtnDeshacer.Click
        controlRTF.Undo()
    End Sub

    Private Sub tsBtnCortar_Click(sender As Object, e As EventArgs) Handles tsBtnCortar.Click
        controlRTF.Cut()
    End Sub

    Private Sub tsBtnCopiar_Click(sender As Object, e As EventArgs) Handles tsBtnCopiar.Click
        controlRTF.Copy()
    End Sub

    Private Sub tsBtnPegar_Click(sender As Object, e As EventArgs) Handles tsBtnPegar.Click
        controlRTF.Paste()
    End Sub

    Private Sub tsBtnIzquierda_Click(sender As Object, e As EventArgs) Handles tsBtnIzquierda.Click
        alinearIzquierda()
    End Sub

    Private Sub tsBtnCentrar_Click(sender As Object, e As EventArgs) Handles tsBtnCentrar.Click
        alinearCentro()
    End Sub

    Private Sub tsBtnDerecha_Click(sender As Object, e As EventArgs) Handles tsBtnDerecha.Click
        alinearDerecha()
    End Sub

    Private Sub tsBtnFonts_Click(sender As Object, e As EventArgs) Handles tsBtnFonts.Click
        cargoFuentes()
    End Sub

    Private Sub tsBtnColor_Click(sender As Object, e As EventArgs) Handles tsBtnColor.Click
        ColorDeFuente()
    End Sub

    Private Sub ZoomAcercarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomAcercarToolStripMenuItem.Click
        AumentoZoom()
    End Sub

    Private Sub ZoomAlejarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomAlejarToolStripMenuItem.Click
        DisminuyoZoom()
    End Sub

    Private Sub VistaNormal11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaNormal11ToolStripMenuItem.Click
        zoom = 1
        If controlRTF.TextLength > 0 Then controlRTF.ZoomFactor = zoom
    End Sub
End Class
