using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

using HutongGames.PlayMaker;
using UnityEditor;
using UnityEngine;
using System;

#pragma warning disable 612

[CustomActionEditor(typeof(XmlSelectNode))]
public class XmlSelectNodeEditor : XmlCustomActionEditor
{

    public override bool OnGUI()
    {
		bool edited = false;
		XmlSelectNode _target = (XmlSelectNode)target;
	
		if (_target.xmlSource==null)
		{
			_target.xmlSource = new FsmXmlSource();
		}
	
		if (_target.xPath==null)
		{
			_target.xPath = new FsmXpathQuery();
		}
	
		edited = edited || DataMakerActionEditorUtils.EditFsmXmlSourceField(_target.Fsm,_target.xmlSource);
				
		edited = edited || DataMakerActionEditorUtils.EditFsmXpathQueryField(_target.Fsm,_target.xPath);
		
		EditField("xmlResult");
		EditField("storeReference");

		EditField("properties");

		EditField("found");
		EditField("foundEvent");
		EditField("notFoundEvent");
		EditField("errorEvent");
		
		return GUI.changed || edited;
    }
	
}
