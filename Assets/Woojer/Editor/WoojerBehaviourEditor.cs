using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Woojer {
	//[CustomEditor(typeof(WoojerBehaviour), true)]
	[CanEditMultipleObjects]
	public class WoojerBehaviourEditor : Editor
	{
		/*SerializedProperty scriptPorperty;
		SerializedProperty impactProperty;
		SerializedProperty rightEarProperty;
		SerializedProperty leftEarProperty;
		SerializedProperty stomachProperty;
		SerializedProperty chestProperty;
		SerializedProperty rightShoulderProperty;
		SerializedProperty leftShoulderProperty;
		SerializedProperty rightWaistProperty;
		SerializedProperty leftWaistProperty;

		void OnEnable()
		{
			scriptPorperty = serializedObject.FindProperty("m_Script");
			impactProperty = serializedObject.FindProperty("Impact");
			rightEarProperty = serializedObject.FindProperty("rightEar");
			leftEarProperty = serializedObject.FindProperty("leftEar");
			stomachProperty = serializedObject.FindProperty("stomach");
			chestProperty = serializedObject.FindProperty("chest");
			rightShoulderProperty = serializedObject.FindProperty("rightShoulder");
			leftShoulderProperty = serializedObject.FindProperty("leftShoulder");
			rightWaistProperty = serializedObject.FindProperty("rightWaist");
			leftWaistProperty = serializedObject.FindProperty("leftWaist");
		}

		public override void OnInspectorGUI()
		{
			//base.OnInspectorGUI();
			serializedObject.Update();
			EditorGUI.BeginDisabledGroup(true);
			EditorGUILayout.PropertyField(scriptPorperty);
			EditorGUI.EndDisabledGroup();
			EditorGUILayout.PropertyField(impactProperty);
			if (GetImpactType(impactProperty) == WoojerBehaviour.ImpactType.Specific)
			{
				EditorGUILayout.PropertyField(rightEarProperty);
				EditorGUILayout.PropertyField(leftEarProperty);
				EditorGUILayout.PropertyField(stomachProperty);
				EditorGUILayout.PropertyField(chestProperty);
				EditorGUILayout.PropertyField(rightShoulderProperty);
				EditorGUILayout.PropertyField(leftShoulderProperty);
				EditorGUILayout.PropertyField(rightWaistProperty);
				EditorGUILayout.PropertyField(leftWaistProperty);
			}
			serializedObject.ApplyModifiedProperties();
		}

		WoojerBehaviour.ImpactType GetImpactType(SerializedProperty impact)
		{
			return (WoojerBehaviour.ImpactType)impact.enumValueIndex;
		}*/
	}
}