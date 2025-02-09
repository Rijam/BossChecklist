﻿using System;

namespace BossChecklist
{
	internal enum EntryType
	{
		Boss,
		MiniBoss,
		Event
	}

	internal enum OrphanType
	{
		Loot,
		Collection,
		SpawnItem,
		EventNPC
	}

	internal enum CollectionType
	{
		Generic,
		Trophy,
		Mask,
		MusicBox,
		Relic,
		Pet,
		Mount
	}

	enum PacketMessageType : byte
	{
		RequestHideBoss,
		RequestClearHidden,
		RequestForceDownBoss,
		RequestClearForceDowns,
		SendRecordsToServer,
		RecordUpdate,
		WorldRecordUpdate,
		ResetTrackers,
		PlayTimeRecordUpdate
	}

	[Flags]
	internal enum NetRecordID : int
	{
		None = 0,
		Duration_Best = 1,
		HitsTaken_Best = 2,
		FirstRecord = 4,
		ResetAll = 8
	}

	internal enum CategoryPage
	{
		Record,
		Spawn,
		Loot
	}

	internal enum RecordCategory
	{
		PreviousAttempt,
		BestRecord,
		FirstRecord,
		WorldRecord,
		None
	}
}
