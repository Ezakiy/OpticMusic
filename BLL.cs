using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public class Conta
        {


            static public DataTable Load(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select Nome,Foto,GeneroMusical,dtNascimento from Conta where id=@id", sqlParams);
            }
            static public DataTable LoadFotoPlaylist(int userId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", userId)
                };
                return dal.executarReader("select UserId,Foto from Playlist where UserId=@UserId", sqlParams);
            }
            static public DataTable queryLogin(string Nome, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                 new SqlParameter("@Senha", Senha)

                };
                return dal.executarReader("select * from Conta where Nome=@Nome and Senha=@Senha", sqlParams);
            }
            static public int UpdateGeneroMusical(string GeneroMusical, int Id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@GeneroMusical", GeneroMusical),
                new SqlParameter("@Id", Id)
            };

                return dal.executarNonQuery("update [Conta] set [GeneroMusical]=@GeneroMusical Where Id=@Id", sqlParams);
            }

            static public int UpdateFoto(byte[] Foto, int Id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Foto", Foto),
                new SqlParameter("@Id", Id)

            };

                return dal.executarNonQuery("update [Conta] set [Foto]=@Foto Where Id=@Id", sqlParams);

            }

            static public int InsertConta(string Nome, string Senha, DateTime dtNascimento, byte[] Foto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Senha", Senha),
                new SqlParameter("@dtNascimento", dtNascimento),
                new SqlParameter("@Foto", Foto)

            };

                return (int)dal.executarScalar("INSERT into Conta (Nome,Senha,dtNascimento,Foto) output INSERTED.Id VALUES(@Nome,@Senha,@dtNascimento,@Foto)", sqlParams);
            }
            static public bool CheckAccountExists(string Nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),

            };

                DataTable result = dal.executarReader("Select * from [Conta] WHERE [Nome]=@Nome", sqlParams);

                return result.Rows.Count > 0;
            }
            static public DataTable CheckSenha(int Id, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Senha", Senha),
                 new SqlParameter("@Id", Id)

            };

                return dal.executarReader("Select * from [Conta] WHERE Id=@Id AND [Senha]=@Senha", sqlParams);


            }
            static public int UpdateConta(int Id, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id", Id),
                new SqlParameter("@Senha", Senha)

            };
                return dal.executarNonQuery("update [Conta] set [Senha]=@Senha where id=@id", sqlParams);
            }
            //static public int InsertGeneroMusical1(string GeneroMusical)
            //{
            //    DAL dal = new DAL();
            //    SqlParameter[] sqlParams = new SqlParameter[]{
            //    new SqlParameter("@GeneroMusical", GeneroMusical),

            //};
            //    return dal.executarNonQuery("INSERT into Conta (GeneroMusical) VALUES(@GeneroMusical)", sqlParams);
            //}


            static public int UpdateConta(int Id, string oldPassword, string newPassword)
            {


                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id", Id),
                new SqlParameter("@Senha", newPassword)
                };

                return dal.executarNonQuery("UPDATE [Conta] SET [Senha] = @Senha WHERE Id = @Id", sqlParams);
            }

            static private bool VerifyOldPassword(int Id, string oldPassword)
            {
                string storedPassword = GetStoredPassword(Id); // Retrieve the stored password for the user from the database

                // Compare the provided old password with the stored password
                bool passwordsMatch = (oldPassword == storedPassword);

                return passwordsMatch;
            }

            static private string GetStoredPassword(int Id)
            {
                string storedPassword = null;

                // Retrieve the stored password for the user with the given Id from the database
                // Implement your logic to fetch the password from the database
                // Return the stored password

                return storedPassword;
            }

            static public int SaveButtonInfo(int userId, int buttonLocationX, int buttonLocationY, string buttonText)
            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", userId),
                new SqlParameter("@ButtonLocationX", buttonLocationX),
                new SqlParameter("@ButtonLocationY", buttonLocationY),
                new SqlParameter("@ButtonText", buttonText),
                };

                return dal.executarNonQuery("Insert into Buttoninfo (UserId,ButtonLocationX,ButtonLocationY,buttonText) VALUES (@UserId,@ButtonLocationX,@ButtonLocationY,@ButtonText)", sqlParams);

            }
            static public int SaveLabelInfo(int userId, int LabelLocationX, int LabelLocationY, string LabelText)
            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", userId),
                new SqlParameter("@LabelLocationX", LabelLocationX),
                new SqlParameter("@LabelLocationY", LabelLocationY),
                new SqlParameter("@LabelText", LabelText),
                };

                return dal.executarNonQuery("Insert into LabelInfo (UserId,LabelLocationX,LabelLocationY,LabelText) VALUES (@UserId,@LabelLocationX,@LabelLocationY,@LabelText)", sqlParams);

            }
            static public int SavePlaylistInfo(int userId, string Nome, byte[] Foto)
            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Foto", Foto)
                };

                return dal.executarNonQuery("Insert into Playlist (UserId,Nome,Foto) VALUES (@UserId,@Nome,@Foto)", sqlParams);

            }
            static public int UpdateFoto(int userId, byte[] Foto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@userId", userId),
                new SqlParameter("@Foto", Foto)
                };

                return dal.executarNonQuery("UPDATE [Playlist] SET [Foto] = @Foto WHERE UserId = @UserId", sqlParams);
            }
            static public DataTable GetLabelInfo(int UserId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", UserId)
                };
                return dal.executarReader("select LabelLocationX, LabelLocationY, LabelText from LabelInfo where UserId=@UserId", sqlParams);
            }

            static public bool CheckButtonExists(int UserId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", UserId),

            };

                DataTable result = dal.executarReader("Select * from [ButtonInfo] WHERE [UserId]=@UserId", sqlParams);

                return result.Rows.Count > 0;
            }

            static public bool CheckLabelExists(int UserId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", UserId),

            };

                DataTable result = dal.executarReader("Select * from [LabelInfo] WHERE [UserId]=@UserId", sqlParams);

                return result.Rows.Count > 0;
            }

            static public int InsertMusica(string fileName, string filePath, int userId)
            {

                try
                {
                    DAL dal = new DAL();

                    SqlParameter[] sqlParams = new SqlParameter[]{
                        new SqlParameter("@#Titulo", fileName),
                        new SqlParameter("@FilePath", filePath),
                        new SqlParameter("@UserId", userId),

                    };

                    return dal.executarNonQuery("Insert into Musicas (#Titulo,FilePath,UserId) VALUES (@#Titulo,@FilePath,@UserId)", sqlParams);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            static public bool RemoveFileFromDatabase(string filePath, int UserId)
            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                        new SqlParameter("@FilePath", filePath),
                        new SqlParameter("@UserId", UserId)
                };

                
                int linhasAfetadas = dal.executarNonQuery("DELETE FROM Musicas WHERE FilePath = @FilePath AND UserId=@UserId", sqlParams);


                //using (SqlCommand command = new SqlCommand(deleteQuery))
                //{
                //    command.Parameters.AddWithValue("@FilePath", filePath);
                //    int rowsAffected = command.ExecuteNonQuery();

                //    if (rowsAffected > 0)
                //    {
                //        // File was successfully deleted
                //        return true;
                //    }
                //    else
                //    {
                //        // File was not found in the database
                //        return false;
                //    }
                //}


                return linhasAfetadas > 0; // Se o nr de linhas afetadas for maior que 0, significa que o DELETE funcionou
            }


            static public DataTable LoadMusicas(int userId)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{
                        new SqlParameter("@UserId", userId),

                };

                return dal.executarReader("Select #Titulo, FilePath from [Musicas] WHERE [UserId]=@UserId", sqlParams);

            }

            static public DataTable GetButtonInfo(int UserId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", UserId)
                };
                return dal.executarReader("select ButtonLocationX, ButtonLocationY, ButtonText from ButtonInfo where UserId=@UserId", sqlParams);
            }

            static public int UpdateLabelText(int Id, string LabelText)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@UserId", Id),
                new SqlParameter("@LabelText", LabelText)
            };

                return dal.executarNonQuery("update [LabelInfo] set [LabelText]=@LabelText Where UserId=@UserId", sqlParams);
            }
            static public int UpdateLabelTextPlaylist(int userId, string LabelText)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Nome", LabelText)
            };

                return dal.executarNonQuery("update [Playlist] set [Nome]=@Nome Where UserId=@UserId", sqlParams);
            }
            public static string LoadLabelText(int userId)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@UserId", userId)
                                                            };
                DataTable result = dal.executarReader("SELECT LabelText FROM LabelInfo WHERE UserId=@UserId", sqlParams);

                // Check if any rows are returned
                if (result.Rows.Count > 0)
                {
                    // Retrieve the label text from the first row and first column
                    string labelText = result.Rows[0][0].ToString();
                    return labelText;
                }
                else
                {
                    // No matching rows found, return an empty string or default text
                    return string.Empty;
                }
            }

        }
    }

}



