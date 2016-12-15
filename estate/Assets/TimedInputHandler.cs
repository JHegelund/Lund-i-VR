using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface TimedInputHandler : IEnumerable {

	void HandleTimedInput();
}
