using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System;

[CustomPropertyDrawer(typeof(TagSelectorAttribute))]
public class TagSelectorDrawer : PropertyDrawer {
	public int index;
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){

		index = System.Array.IndexOf (InternalEditorUtility.tags, property.stringValue);
		index = EditorGUI.Popup(position,label.text,index,InternalEditorUtility.tags);
		if(index >= 0){
		property.stringValue = InternalEditorUtility.tags[index];
		}
	}

	}

