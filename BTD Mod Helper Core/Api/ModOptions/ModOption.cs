﻿using BTD_Mod_Helper.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace BTD_Mod_Helper.Api.ModOptions
{
    /// <summary>
    /// Visual component to a ModSetting
    /// </summary>
    public class ModOption
    {
        private readonly ModSetting modSetting;
        internal GameObject instantiatedGameObject;
        internal RectTransform rectTransform;
        internal GameObject parent;
        internal Text title;

        internal ModOption(GameObject parentGO)
        {
            parent = parentGO;
        }

        internal ModOption(GameObject parentGO, string gameObjectName) : this (parentGO)
        {
            rectTransform = parent.GetComponentInChildrenByName<RectTransform>(gameObjectName);
            rectTransform.Hide();

            var go = rectTransform.gameObject;
            var modOptionsContainer = parentGO.GetComponentInChildrenByName<RectTransform>("ModOptions Container");

            instantiatedGameObject = Object.Instantiate(go, modOptionsContainer);
            title = instantiatedGameObject.transform.Find("OptionBase/Name").GetComponent<Text>();
            
            instantiatedGameObject.Show();
        }

        internal ModOption(GameObject parentGO, ModSetting modSetting, string gameObjectName) : this(parentGO, gameObjectName)
        {
            this.modSetting = modSetting;
            title.text = modSetting.GetName();
        }

        internal void Show()
        {
            instantiatedGameObject.Show();
        }

        internal void Hide()
        {
            instantiatedGameObject.Hide();
        }

        /// <summary>
        /// Gets the ModSetting for this ModOption
        /// </summary>
        public virtual ModSetting GetModSetting()
        {
            return modSetting;
        }

        internal void SetLocation(float yCoord)
        {
            instantiatedGameObject.transform.position = new Vector3(rectTransform.position.x, yCoord);
        }

        internal static RectTransform GetOriginalAsset(GameObject parentGO, string name)
        {
            return parentGO.GetComponentInChildrenByName<RectTransform>(name);
        }
    }
}
