class MyCustomSection : ConfigurationSection {
      public MyCustomSection() {
      }

      public bool BooleanProperty {
        get {
          return (bool)base["booleanProperty"];
        }
     set {
          base["booleanProperty"] = value;
        }
      }
      public string StringProperty {
        get {
          return (string)base["stringProperty"];
        }
        set {
          base["stringProperty"] = value;
        }
      }

      public int IntegerProperty {
        get {
          return (int)base["integerProperty"];
        }
        set {
          base["integerProperty"] = value;
        }
      }

      public EnumValue EnumProperty {
        get {
          return (EnumValue)base["enumProperty"];
        }
        set {
          base["enumProperty"] = value;
        }
      }
    }

    public enum EnumValue {
      EnumValue1 = 1,
      EnumValue2 = 2
    }