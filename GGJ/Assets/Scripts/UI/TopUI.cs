using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopUI : MonoBehaviour
{
	[SerializeField] TopRoom[] rooms;
	RoomUI roomUI;

	public void InitRooms(Patient[] patients, RoomUI roomUI) {
		this.roomUI = roomUI;
		for (byte i = 0; i < patients.Length; ++i) 
			rooms[i].InitRoom(patients[i]);
		OnRoomClick(0);
	}

	public void OnRoomClick(int roomId) {
		if(rooms[roomId].patient != null)
			roomUI.ChangePatient(rooms[roomId].patient);
	}
}
