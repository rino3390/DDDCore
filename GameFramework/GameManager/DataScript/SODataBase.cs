﻿using GameFramework.GameManager.Common;
using GameFramework.RinoUtility.Misc;
using Sirenix.OdinInspector;

namespace GameFramework.GameManager.DataScript
{
	public abstract class SODataBase: SerializedScriptableObject
	{
		[ReadOnly]
		[HorizontalGroup(LayoutConst.TopInfoLayout)]
		[VerticalGroup(LayoutConst.TopInfoLayout + "/1")]
		[PropertySpace(10)]
		public string Id;

		[HorizontalGroup(LayoutConst.TopInfoLayout)]
		[VerticalGroup(LayoutConst.TopInfoLayout + "/1")]
		[LabelText("檔案名稱")]
		[PropertySpace(10), ValidateInput("CheckValidate")]
		public string AssetName;

	#if UNITY_EDITOR
		public virtual bool CheckValidate()
		{
			return !string.IsNullOrEmpty(AssetName) && RegexChecking.OnlyEnglishAndNum(AssetName);
		}
	#endif
	}
}