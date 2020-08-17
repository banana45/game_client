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

	// defined in */scripts/entity_defs/FirstEntity.def
	public class EntityBaseEntityCall_FirstEntityBase : EntityCall
	{

		public EntityBaseEntityCall_FirstEntityBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_FirstEntityBase : EntityCall
	{

		public EntityCellEntityCall_FirstEntityBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void removeEquip(Int32 arg1)
		{
			Bundle pBundle = newCall("removeEquip", 0);
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			sendCall(null);
		}

	}
	}
