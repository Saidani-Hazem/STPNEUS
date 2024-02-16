Imports System.Data.SQLite
Module pneus
    Structure pneu
        Dim code As Integer
        Dim refrence As String
        Dim marque As String
        Dim type As String
        Dim dateE As Date
        Dim prixu As Double
        Dim qte As Integer
    End Structure
    Structure entree
        Dim code As Integer
        Dim id As Integer
        Dim refrence As String
        Dim marque As String
        Dim type As String
        Dim dateE As Date
        Dim prix_U_ACHAT As Double
        Dim qte As Integer
    End Structure
    Structure sortie
        Dim code As Integer
        Dim id As Integer
        Dim refrence As String
        Dim marque As String
        Dim type As String
        Dim dateS As Date
        Dim prix_U_Vente As Double
        Dim qte As Integer
    End Structure

    Dim ch As String = "Data Source = C:\Program Files\base\base.db"

    Public Sub ajoutAchat(E As entree)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "INSERT INTO Entree (code_E ,id, réference , Marque , Type_pneu , Date , PrixUN_Achat ,Quantite) VALUES (@code,@id,@refrence ,@marque ,@type,@date ,@prixu ,@qte);"
            Using cmd As New SQLiteCommand(requete, con)
                cmd.Parameters.AddWithValue("@code", E.code)
                cmd.Parameters.AddWithValue("@id", E.id)
                cmd.Parameters.AddWithValue("@refrence", E.refrence)
                cmd.Parameters.AddWithValue("@marque", E.marque)
                cmd.Parameters.AddWithValue("@type", E.type)
                cmd.Parameters.AddWithValue("@date", E.dateE)
                cmd.Parameters.AddWithValue("@prixu", E.prix_U_ACHAT)
                cmd.Parameters.AddWithValue("@qte", E.qte)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ajoutPN(p As pneu)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "INSERT INTO Pneus (réference, Marque, type, Date_entree, prix_Unitaire, Quantite) VALUES (@refrence, @marque, @type, @Date, @prixu, @qte);"
            Using cmd As New SQLiteCommand(requete, con)
                cmd.Parameters.AddWithValue("@refrence", p.refrence)
                cmd.Parameters.AddWithValue("@marque", p.marque)
                cmd.Parameters.AddWithValue("@type", p.type)
                cmd.Parameters.AddWithValue("@Date", p.dateE)
                cmd.Parameters.AddWithValue("@prixu", p.prixu)
                cmd.Parameters.AddWithValue("@qte", p.qte)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ajoutSortie(S As sortie)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "INSERT INTO Sortie (Code_S ,id ,réference , Marque , Type_pneu , Date , PrixUN_Vente ,Quantite) VALUES (@code,@id,@refrence ,@marque ,@type,@date ,@prixu ,@qte);"
            Using cmd As New SQLiteCommand(requete, con)
                cmd.Parameters.AddWithValue("@code", S.code)
                cmd.Parameters.AddWithValue("@id", S.id)
                cmd.Parameters.AddWithValue("@refrence", S.refrence)
                cmd.Parameters.AddWithValue("@marque", S.marque)
                cmd.Parameters.AddWithValue("@type", S.type)
                cmd.Parameters.AddWithValue("@date", S.dateS)
                cmd.Parameters.AddWithValue("@prixu", S.prix_U_Vente)
                cmd.Parameters.AddWithValue("@qte", S.qte)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AfficheSock(dgv As DataGridView)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT * FROM pneus"
            Dim cmd As New SQLiteCommand(requete, con)
            Dim sda As New SQLiteDataAdapter(cmd)

            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Function CODE() As Integer
        Dim l As Integer = 0
        Dim c As Integer = 0
        Using conn As New SQLiteConnection(ch)
            conn.Open()
            Dim requete As String = "select count(Code_E) from Entree;"
            Using cmd As New SQLiteCommand(requete, conn)
                l = Convert.ToInt16(cmd.ExecuteScalar())
            End Using
            c = l + 1
        End Using
        Return c
    End Function
    Public Function CODESRT() As Integer
        Dim l As Integer = 0
        Dim c As Integer = 0
        Using conn As New SQLiteConnection(ch)
            conn.Open()
            Dim requete As String = "select count(Code_S) from Sortie;"
            Using cmd As New SQLiteCommand(requete, conn)
                l = Convert.ToInt16(cmd.ExecuteScalar())
            End Using
            c = l + 1
        End Using
        Return c
    End Function
    Public Function CODEACH() As Integer
        Dim l As Integer = 0
        Dim c As Integer = 0
        Using conn As New SQLiteConnection(ch)
            conn.Open()
            Dim requete As String = "select max(code) from pneus;"
            Using cmd As New SQLiteCommand(requete, conn)
                l = Convert.ToInt16(cmd.ExecuteScalar())
            End Using
        End Using
        Return l
    End Function
    Public Sub AffRT(dgv As DataGridView, reference As String)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT * FROM pneus WHERE réference = @reference;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@reference", reference)
            Dim sda As New SQLiteDataAdapter(cmd)

            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub MAJsupp(dgv As DataGridView, code As Integer)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "DELETE FROM pneus WHERE Code = @code;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@code", code)
            Dim sda As New SQLiteDataAdapter(cmd)

            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub MAJ(dgv As DataGridView, vente As Integer, selected As Integer)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "UPDATE pneus SET Quantite = Quantite - @vente WHERE code = @selected;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@vente", vente)
            cmd.Parameters.AddWithValue("@selected", selected)
            Dim sda As New SQLiteDataAdapter(cmd)

            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub AfficheEntre(dgv As DataGridView, datedeb As Date, datefin As Date)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT id , réference , Marque , Type_pneu , Date , PrixUN_Achat ,Quantite FROM entree WHERE date BETWEEN @datedeb AND @datefin;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@datedeb", datedeb)
            cmd.Parameters.AddWithValue("@datefin", datefin)
            Dim sda As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub AfficheEntreref(dgv As DataGridView, datedeb As Date, datefin As Date, ref As String)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT id,  réference , Marque , Type_pneu , Date , PrixUN_Achat ,Quantite FROM entree WHERE réference = @ref and date BETWEEN @datedeb AND @datefin;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@datedeb", datedeb)
            cmd.Parameters.AddWithValue("@datefin", datefin)
            cmd.Parameters.AddWithValue("@ref", ref)
            Dim sda As New SQLiteDataAdapter(cmd)

            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub Affichesort(dgv As DataGridView, datedebu As Date, datefini As Date)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT id, réference , Marque , Type_pneu , Date , PrixUN_Vente ,Quantite FROM sortie WHERE date BETWEEN @datedeb AND @datefin;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@datedeb", datedebu)
            cmd.Parameters.AddWithValue("@datefin", datefini)
            Dim sda As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub Affichesortref(dgv As DataGridView, datedebu As Date, datefini As Date, ref As String)
        Using con As New SQLiteConnection(ch)
            con.Open()
            Dim requete As String = "SELECT id,  réference , Marque , Type_pneu , Date , PrixUN_Vente ,Quantite FROM sortie WHERE réference = @ref and date BETWEEN @datedeb AND @datefin;"
            Dim cmd As New SQLiteCommand(requete, con)
            cmd.Parameters.AddWithValue("@datedeb", datedebu)
            cmd.Parameters.AddWithValue("@datefin", datefini)
            cmd.Parameters.AddWithValue("@ref", ref)
            Dim sda As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
End Module