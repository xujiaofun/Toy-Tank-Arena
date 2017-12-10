//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public FireTimeComponent fireTime { get { return (FireTimeComponent)GetComponent(GameComponentsLookup.FireTime); } }
    public bool hasFireTime { get { return HasComponent(GameComponentsLookup.FireTime); } }

    public void AddFireTime(float newValue) {
        var index = GameComponentsLookup.FireTime;
        var component = CreateComponent<FireTimeComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFireTime(float newValue) {
        var index = GameComponentsLookup.FireTime;
        var component = CreateComponent<FireTimeComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFireTime() {
        RemoveComponent(GameComponentsLookup.FireTime);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherFireTime;

    public static Entitas.IMatcher<GameEntity> FireTime {
        get {
            if (_matcherFireTime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FireTime);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFireTime = matcher;
            }

            return _matcherFireTime;
        }
    }
}
