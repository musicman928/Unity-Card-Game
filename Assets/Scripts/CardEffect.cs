using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffect {
    public delegate void EffectDelegate();
    private EffectDelegate effect;

    public CardEffect(EffectDelegate effect) {
        this.effect = effect;
    }

    public void Invoke() {
        effect.Invoke();
    }

    
}
