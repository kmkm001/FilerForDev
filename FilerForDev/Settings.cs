using System;
using System.Collections;

namespace FilerForDev
{
	// 本クラスの機能
	//   汎用的な設定データの管理
	//   ファイル読み込み、書き込み(ファイル形式は未定)

    public class Settings : DataFile
	{

		#region 定義
		/*-------------------------------------------------------------------------
		*	定義
		*------------------------------------------------------------------------*/

		#endregion 定義

		#region メンバ
		/*-------------------------------------------------------------------------
		*	プロパティ
		*------------------------------------------------------------------------*/
		[System.Xml.Serialization.XmlIgnore]
		// 設定ファイル
		private string _settingsFileName = @"SettingsFile.xml";
        public string SettingsFile
        {
            get { return _settingsFileName; }
            set { _settingsFileName = value; }
        }
		// 起動時の表示設定
		[System.Xml.Serialization.XmlElement("DefaultVisible")]
		private bool _defaultVisible = true;
        public bool DefaultVisible
        {
            get { return _defaultVisible; }
            set { _defaultVisible = value; }
        }
        // ソートモードのインデックス
		[System.Xml.Serialization.XmlElement("SortModeIndex")]
		private int _sortModeIndex = 0;
        public int SortModeIndex
        {
            get { return _sortModeIndex; }
            set { _sortModeIndex = value; }
        }

		#endregion メンバ

		#region メソッド
		/*-------------------------------------------------------------------------
		*	メソッド
		*------------------------------------------------------------------------*/
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="fileName"></param>
		public Settings(String fileName){
			_settingsFileName = fileName;
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
        public Settings()
		{
		}

		/// <summary>
		/// 読み込み
		/// </summary>
		/// <returns></returns>
		public Boolean LoadSettings(){
			Boolean ret = false;
            Settings data = new Settings();
			try
			{
				ret = LoadFromXMLFile(ref data, _settingsFileName);
			}
			catch
			{
				return ret;
			}
            // --------------------------------------------------
            // 読み込む設定
			this._defaultVisible = data._defaultVisible;
			this._sortModeIndex = data._sortModeIndex;
            // --------------------------------------------------

			data = null;
			return ret;
		}

		/// <summary>
		/// 保存
		/// </summary>
		/// <returns></returns>
		public Boolean SaveSettings()
		{
			Boolean ret = false;
			try
			{
				ret = SaveToXMLFile(this, _settingsFileName);
			}
			catch
			{
				return ret;
			}
			return ret;
		}

		#endregion メソッド

	}
}
