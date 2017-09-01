using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomPropertyDrawer(typeof(TagSelectorAttribute))]
public class TagSelectorDrawer : PropertyDrawer {
	public int index;
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){

		index = EditorGUI.Popup(position,label.text,index,InternalEditorUtility.tags);
	}


}
