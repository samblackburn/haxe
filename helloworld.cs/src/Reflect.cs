// Generated by Haxe 4.3.4

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Reflect : global::haxe.lang.HxObject {
	
	public Reflect(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Reflect() {
		global::Reflect.__hx_ctor__Reflect(this);
	}
	
	
	protected static void __hx_ctor__Reflect(global::Reflect __hx_this) {
	}
	
	
	public static object field(object o, string field) {
		global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
		if (( ihx != null )) {
			return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, false);
		}
		
		return global::haxe.lang.Runtime.slowGetField(o, field, false);
	}
	
	
	public static void setField(object o, string field, object @value) {
		global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
		if (( ihx != null )) {
			ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, false);
		}
		else {
			global::haxe.lang.Runtime.slowSetField(o, field, @value);
		}
		
	}
	
	
	public static global::Array<string> fields(object o) {
		global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
		if (( ihx != null )) {
			global::Array<string> ret = new global::Array<string>(new string[]{});
			ihx.__hx_getFields(ret);
			return ret;
		}
		else if (( o is global::System.Type )) {
			return global::Type.getClassFields(((global::System.Type) (o) ));
		}
		else {
			return global::Reflect.instanceFields(o.GetType());
		}
		
	}
	
	
	public static global::Array<string> instanceFields(global::System.Type c) {
		global::System.Type c1 = ((global::System.Type) (c) );
		global::Array<string> ret = new global::Array<string>(new string[]{});
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Public, true);
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( (((global::System.Reflection.BindingFlags) (( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) )) )) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) ), true);
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( (((global::System.Reflection.BindingFlags) (( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) )) )) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
		global::System.Reflection.FieldInfo[] mis = c1.GetFields(((global::System.Reflection.BindingFlags) (( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) )) ));
		{
			int _g = 0;
			int _g1 = ( mis as global::System.Array ).Length;
			while (( _g < _g1 )) {
				int i = _g++;
				global::System.Reflection.FieldInfo i1 = ((global::System.Reflection.FieldInfo) (mis[i]) );
				ret.push(( i1 as global::System.Reflection.MemberInfo ).Name);
			}
			
		}
		
		return ret;
	}
	
	
}


