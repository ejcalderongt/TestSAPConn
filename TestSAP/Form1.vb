Imports DevExpress.Utils.Frames
Imports SAPbobsCOM

Public Class Form1

    Private oCompany As Company

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function Connect_To_Sap1() As Boolean

        Connect_To_Sap1 = False

        Try

            oCompany = New Company
            oCompany.SLDServer = txtLICENSESERVER_SAP_BO.Text.Trim()
            oCompany.LicenseServer = txtSERVER_BD_SAP.Text.Trim()
            oCompany.Server = txtSERVER_BD_SAP.Text.Trim()
            oCompany.CompanyDB = txtSAP_COMPANY_DB.Text.Trim()
            oCompany.UserName = txtSAP_USR.Text.Trim()
            oCompany.Password = txtSAP_USR_PW.Text.Trim()
            oCompany.DbUserName = txtSAP_DB_USR.Text.Trim()
            oCompany.DbPassword = txtSAP_DB_PW.Text.Trim()
            oCompany.language = BoSuppLangs.ln_Spanish_La
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2017
            oCompany.UseTrusted = False

            Dim lRetCode As Integer = oCompany.Connect()
            Dim errMsg As String = oCompany.GetLastErrorDescription()
            Dim ErrNo As Integer = oCompany.GetLastErrorCode()
            Dim ErrContext As String = oCompany.GetLastErrorContext()

            If ErrNo <> 0 Then
                MsgBox("No: " & errMsg)
            Else
                Connect_To_Sap1 = True
                MsgBox("Conectado a SAP")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a SAP")
        End Try

    End Function

    Private Function Connect_To_Sap2() As Boolean

        Connect_To_Sap2 = False

        Try

            oCompany = New Company
            oCompany.LicenseServer = txtLICENSESERVER_SAP_BO.Text.Trim()
            oCompany.Server = txtSERVER_BD_SAP.Text.Trim()
            oCompany.CompanyDB = txtSAP_COMPANY_DB.Text.Trim()
            oCompany.UserName = txtSAP_DB_USR.Text.Trim()
            oCompany.Password = txtSAP_USR_PW.Text.Trim()
            oCompany.DbUserName = txtSAP_DB_USR.Text.Trim()
            oCompany.DbPassword = txtSAP_DB_PW.Text.Trim()
            oCompany.language = BoSuppLangs.ln_Spanish_La
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2017
            oCompany.UseTrusted = False

            Dim lRetCode As Integer = oCompany.Connect()
            Dim errMsg As String = oCompany.GetLastErrorDescription()
            Dim ErrNo As Integer = oCompany.GetLastErrorCode()
            Dim ErrContext As String = oCompany.GetLastErrorContext()

            If ErrNo <> 0 Then
                MsgBox("No_2")
            Else
                Connect_To_Sap2 = True
                MsgBox("Conectado a SAP")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a SAP")
        End Try

    End Function

    Private Function Connect_To_Sap3() As Boolean

        Connect_To_Sap3 = False

        Try

            oCompany = New Company
            oCompany.SLDServer = txtLICENSESERVER_SAP_BO.Text.Trim()
            oCompany.LicenseServer = txtLICENSESERVER_SAP_BO.Text.Trim()
            oCompany.Server = txtSERVER_BD_SAP.Text.Trim()
            oCompany.CompanyDB = txtSAP_COMPANY_DB.Text.Trim()
            oCompany.UserName = txtSAP_DB_USR.Text.Trim()
            oCompany.Password = txtSAP_USR_PW.Text.Trim()
            oCompany.DbUserName = txtSAP_DB_USR.Text.Trim()
            oCompany.DbPassword = txtSAP_DB_PW.Text.Trim()
            oCompany.language = BoSuppLangs.ln_Spanish_La
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2017
            oCompany.UseTrusted = False

            Dim lRetCode As Integer = oCompany.Connect()
            Dim errMsg As String = oCompany.GetLastErrorDescription()
            Dim ErrNo As Integer = oCompany.GetLastErrorCode()
            Dim ErrContext As String = oCompany.GetLastErrorContext()

            If ErrNo <> 0 Then
                MsgBox("No_3")
            Else
                Connect_To_Sap3 = True
                MsgBox("Conectado a SAP")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a SAP")
        End Try

    End Function

    Private Function Connect_To_Sap4() As Boolean

        Connect_To_Sap4 = False

        Try

            oCompany = New Company
            oCompany.Server = txtSERVER_BD_SAP.Text.Trim()
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2017
            oCompany.CompanyDB = txtSAP_COMPANY_DB.Text.Trim()
            oCompany.UserName = txtSAP_DB_USR.Text.Trim()
            oCompany.Password = txtSAP_USR_PW.Text.Trim()
            oCompany.DbUserName = txtSAP_DB_USR.Text.Trim()
            oCompany.DbPassword = txtSAP_DB_PW.Text.Trim()
            oCompany.language = BoSuppLangs.ln_Spanish_La
            oCompany.UseTrusted = False

            Dim lRetCode As Integer = oCompany.Connect()
            Dim errMsg As String = oCompany.GetLastErrorDescription()
            Dim ErrNo As Integer = oCompany.GetLastErrorCode()
            Dim ErrContext As String = oCompany.GetLastErrorContext()

            If ErrNo <> 0 Then
                MsgBox(errMsg, MsgBoxStyle.Critical, "Error al conectar a SAP4")
            Else
                Connect_To_Sap4 = True
                MsgBox("Conectado a SAP")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a SAP")
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Connect_To_Sap1() Then

        End If
    End Sub

End Class
