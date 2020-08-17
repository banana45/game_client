/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class EntityDef
	{
		public static Dictionary<string, UInt16> datatype2id = new Dictionary<string, UInt16>();
		public static Dictionary<string, DATATYPE_BASE> datatypes = new Dictionary<string, DATATYPE_BASE>();
		public static Dictionary<UInt16, DATATYPE_BASE> id2datatypes = new Dictionary<UInt16, DATATYPE_BASE>();
		public static Dictionary<string, Int32> entityclass = new Dictionary<string, Int32>();
		public static Dictionary<string, ScriptModule> moduledefs = new Dictionary<string, ScriptModule>();
		public static Dictionary<UInt16, ScriptModule> idmoduledefs = new Dictionary<UInt16, ScriptModule>();

		public static bool init()
		{
			initDataTypes();
			initDefTypes();
			initScriptModules();
			return true;
		}

		public static bool reset()
		{
			clear();
			return init();
		}

		public static void clear()
		{
			datatype2id.Clear();
			datatypes.Clear();
			id2datatypes.Clear();
			entityclass.Clear();
			moduledefs.Clear();
			idmoduledefs.Clear();
		}

		public static void initDataTypes()
		{
			datatypes["UINT8"] = new DATATYPE_UINT8();
			datatypes["UINT16"] = new DATATYPE_UINT16();
			datatypes["UINT32"] = new DATATYPE_UINT32();
			datatypes["UINT64"] = new DATATYPE_UINT64();

			datatypes["INT8"] = new DATATYPE_INT8();
			datatypes["INT16"] = new DATATYPE_INT16();
			datatypes["INT32"] = new DATATYPE_INT32();
			datatypes["INT64"] = new DATATYPE_INT64();

			datatypes["FLOAT"] = new DATATYPE_FLOAT();
			datatypes["DOUBLE"] = new DATATYPE_DOUBLE();

			datatypes["STRING"] = new DATATYPE_STRING();
			datatypes["VECTOR2"] = new DATATYPE_VECTOR2();

			datatypes["VECTOR3"] = new DATATYPE_VECTOR3();

			datatypes["VECTOR4"] = new DATATYPE_VECTOR4();
			datatypes["PYTHON"] = new DATATYPE_PYTHON();

			datatypes["UNICODE"] = new DATATYPE_UNICODE();
			datatypes["ENTITYCALL"] = new DATATYPE_ENTITYCALL();

			datatypes["BLOB"] = new DATATYPE_BLOB();
		}

		public static void initScriptModules()
		{
			ScriptModule pFirstEntityModule = new ScriptModule("FirstEntity");
			EntityDef.moduledefs["FirstEntity"] = pFirstEntityModule;
			EntityDef.idmoduledefs[1] = pFirstEntityModule;

			Property pFirstEntity_position = new Property();
			pFirstEntity_position.name = "position";
			pFirstEntity_position.properUtype = 40000;
			pFirstEntity_position.properFlags = 4;
			pFirstEntity_position.aliasID = 1;
			Vector3 FirstEntity_position_defval = new Vector3();
			pFirstEntity_position.defaultVal = FirstEntity_position_defval;
			pFirstEntityModule.propertys["position"] = pFirstEntity_position; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_position.aliasID] = pFirstEntity_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(position / 40000).");

			Property pFirstEntity_direction = new Property();
			pFirstEntity_direction.name = "direction";
			pFirstEntity_direction.properUtype = 40001;
			pFirstEntity_direction.properFlags = 4;
			pFirstEntity_direction.aliasID = 2;
			Vector3 FirstEntity_direction_defval = new Vector3();
			pFirstEntity_direction.defaultVal = FirstEntity_direction_defval;
			pFirstEntityModule.propertys["direction"] = pFirstEntity_direction; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_direction.aliasID] = pFirstEntity_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(direction / 40001).");

			Property pFirstEntity_spaceID = new Property();
			pFirstEntity_spaceID.name = "spaceID";
			pFirstEntity_spaceID.properUtype = 40002;
			pFirstEntity_spaceID.properFlags = 16;
			pFirstEntity_spaceID.aliasID = 3;
			UInt32 FirstEntity_spaceID_defval;
			UInt32.TryParse("", out FirstEntity_spaceID_defval);
			pFirstEntity_spaceID.defaultVal = FirstEntity_spaceID_defval;
			pFirstEntityModule.propertys["spaceID"] = pFirstEntity_spaceID; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_spaceID.aliasID] = pFirstEntity_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(spaceID / 40002).");

			Property pFirstEntity_characters = new Property();
			pFirstEntity_characters.name = "characters";
			pFirstEntity_characters.properUtype = 1;
			pFirstEntity_characters.properFlags = 4;
			pFirstEntity_characters.aliasID = 4;
			pFirstEntity_characters.defaultVal = EntityDef.id2datatypes[22].parseDefaultValStr("");
			pFirstEntityModule.propertys["characters"] = pFirstEntity_characters; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_characters.aliasID] = pFirstEntity_characters;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(characters / 1).");

			Property pFirstEntity_test = new Property();
			pFirstEntity_test.name = "test";
			pFirstEntity_test.properUtype = 3;
			pFirstEntity_test.properFlags = 16;
			pFirstEntity_test.aliasID = 5;
			pFirstEntity_test.defaultVal = EntityDef.id2datatypes[23].parseDefaultValStr("");
			pFirstEntityModule.propertys["test"] = pFirstEntity_test; 

			pFirstEntityModule.usePropertyDescrAlias = true;
			pFirstEntityModule.idpropertys[(UInt16)pFirstEntity_test.aliasID] = pFirstEntity_test;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), property(test / 3).");

			List<DATATYPE_BASE> pFirstEntity_onAddEquip_args = new List<DATATYPE_BASE>();
			pFirstEntity_onAddEquip_args.Add(EntityDef.id2datatypes[8]);

			Method pFirstEntity_onAddEquip = new Method();
			pFirstEntity_onAddEquip.name = "onAddEquip";
			pFirstEntity_onAddEquip.methodUtype = 4;
			pFirstEntity_onAddEquip.aliasID = 1;
			pFirstEntity_onAddEquip.args = pFirstEntity_onAddEquip_args;

			pFirstEntityModule.methods["onAddEquip"] = pFirstEntity_onAddEquip; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onAddEquip.aliasID] = pFirstEntity_onAddEquip;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onAddEquip / 4).");

			List<DATATYPE_BASE> pFirstEntity_onEnter_args = new List<DATATYPE_BASE>();

			Method pFirstEntity_onEnter = new Method();
			pFirstEntity_onEnter.name = "onEnter";
			pFirstEntity_onEnter.methodUtype = 1;
			pFirstEntity_onEnter.aliasID = 2;
			pFirstEntity_onEnter.args = pFirstEntity_onEnter_args;

			pFirstEntityModule.methods["onEnter"] = pFirstEntity_onEnter; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onEnter.aliasID] = pFirstEntity_onEnter;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onEnter / 1).");

			List<DATATYPE_BASE> pFirstEntity_onRemoveEquip_args = new List<DATATYPE_BASE>();
			pFirstEntity_onRemoveEquip_args.Add(EntityDef.id2datatypes[8]);

			Method pFirstEntity_onRemoveEquip = new Method();
			pFirstEntity_onRemoveEquip.name = "onRemoveEquip";
			pFirstEntity_onRemoveEquip.methodUtype = 5;
			pFirstEntity_onRemoveEquip.aliasID = 3;
			pFirstEntity_onRemoveEquip.args = pFirstEntity_onRemoveEquip_args;

			pFirstEntityModule.methods["onRemoveEquip"] = pFirstEntity_onRemoveEquip; 
			pFirstEntityModule.useMethodDescrAlias = true;
			pFirstEntityModule.idmethods[(UInt16)pFirstEntity_onRemoveEquip.aliasID] = pFirstEntity_onRemoveEquip;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(onRemoveEquip / 5).");

			List<DATATYPE_BASE> pFirstEntity_removeEquip_args = new List<DATATYPE_BASE>();
			pFirstEntity_removeEquip_args.Add(EntityDef.id2datatypes[8]);

			Method pFirstEntity_removeEquip = new Method();
			pFirstEntity_removeEquip.name = "removeEquip";
			pFirstEntity_removeEquip.methodUtype = 3;
			pFirstEntity_removeEquip.aliasID = -1;
			pFirstEntity_removeEquip.args = pFirstEntity_removeEquip_args;

			pFirstEntityModule.methods["removeEquip"] = pFirstEntity_removeEquip; 
			pFirstEntityModule.cell_methods["removeEquip"] = pFirstEntity_removeEquip;

			pFirstEntityModule.idcell_methods[pFirstEntity_removeEquip.methodUtype] = pFirstEntity_removeEquip;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FirstEntity), method(removeEquip / 3).");

		}

		public static void initDefTypes()
		{
			{
				UInt16 utype = 2;
				string typeName = "BOOL";
				string name = "UINT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 3;
				string typeName = "UINT16";
				string name = "UINT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 5;
				string typeName = "UID";
				string name = "UINT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 4;
				string typeName = "ENTITY_UTYPE";
				string name = "UINT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 6;
				string typeName = "INT8";
				string name = "INT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 7;
				string typeName = "INT16";
				string name = "INT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 8;
				string typeName = "MP";
				string name = "INT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 9;
				string typeName = "INT64";
				string name = "INT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 1;
				string typeName = "STRING";
				string name = "STRING";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 12;
				string typeName = "UNICODE";
				string name = "UNICODE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 13;
				string typeName = "FLOAT";
				string name = "FLOAT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 14;
				string typeName = "DOUBLE";
				string name = "DOUBLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "UID1";
				string name = "PYTHON";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_DICT";
				string name = "PY_DICT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_TUPLE";
				string name = "PY_TUPLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_LIST";
				string name = "PY_LIST";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 20;
				string typeName = "ENTITYCALL";
				string name = "ENTITYCALL";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 11;
				string typeName = "BLOB";
				string name = "BLOB";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 15;
				string typeName = "VECTOR2";
				string name = "VECTOR2";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 16;
				string typeName = "DIRECTION3D";
				string name = "VECTOR3";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 17;
				string typeName = "VECTOR4";
				string name = "VECTOR4";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 22;
				string typeName = "AVATAR_INFOS";
				DATATYPE_AVATAR_INFOS datatype = new DATATYPE_AVATAR_INFOS();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 23;
				string typeName = "AnonymousArray_23";
				DATATYPE_AnonymousArray_23 datatype = new DATATYPE_AnonymousArray_23();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 24;
				string typeName = "AnonymousArray_24";
				string name = "ENTITY_COMPONENT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			foreach(string datatypeStr in EntityDef.datatypes.Keys)
			{
				DATATYPE_BASE dataType = EntityDef.datatypes[datatypeStr];
				if(dataType != null)
				{
					dataType.bind();
				}
			}
		}

	}


}