using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FilerForDev
{
    class DataFile
    {
        #region 定義
        /*-------------------------------------------------------------------------
		*	定義
		*------------------------------------------------------------------------*/

        #endregion 定義

        #region メンバ
        /*-------------------------------------------------------------------------
		*	メンバ
		*------------------------------------------------------------------------*/

        #endregion メンバ

        #region メソッド
        /*-------------------------------------------------------------------------
		*	メソッド
		*------------------------------------------------------------------------*/
        /// <summary>
        /// 保存
        /// </summary>
        /// <typeparam name="TypeName"></typeparam>
        /// <param name="data"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        protected Boolean LoadFromXMLFile<TypeName>(ref TypeName data, string path)
        {
            Boolean ret = true;
            // XmlSerializerオブジェクトを作成
            XmlSerializer serializer = new XmlSerializer(typeof(TypeName));
            // 読み込むファイルを開く
            StreamReader sr = new StreamReader(path, new UTF8Encoding(false));
            try
            {
                // XMLファイルから読み込み、逆シリアル化する
                data = (TypeName)serializer.Deserialize(sr);
            }
            catch (Exception e)
            {
                ret = false;
            }
            finally
            {
                // ファイルを閉じる
                sr.Close();
            }
            return ret;
        }

        /// <summary>
        /// 読み込み
        /// </summary>
        /// <typeparam name="TypeName"></typeparam>
        /// <param name="data"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        protected Boolean SaveToXMLFile<TypeName>(TypeName data, string path)
        {
            Boolean ret = true;
            // XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            XmlSerializer serializer = new XmlSerializer(typeof(TypeName));
            // 書き込むファイルを開く（UTF-8 BOM無し）
            StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(false));
            try
            {
                // シリアル化し、XMLファイルに保存する
                serializer.Serialize(sw, data);
            }
            catch (Exception e)
            {
                ret = false;
            }
            finally
            {
                // ファイルを閉じる
                sw.Close();
            }
            return ret;
        }

        #endregion メソッド

    }
}
