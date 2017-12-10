//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PositonComponent positon { get { return (PositonComponent)GetComponent(GameComponentsLookup.Positon); } }
    public bool hasPositon { get { return HasComponent(GameComponentsLookup.Positon); } }

    public void AddPositon(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Positon;
        var component = CreateComponent<PositonComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePositon(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Positon;
        var component = CreateComponent<PositonComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePositon() {
        RemoveComponent(GameComponentsLookup.Positon);
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

    static Entitas.IMatcher<GameEntity> _matcherPositon;

    public static Entitas.IMatcher<GameEntity> Positon {
        get {
            if (_matcherPositon == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Positon);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPositon = matcher;
            }

            return _matcherPositon;
        }
    }
}