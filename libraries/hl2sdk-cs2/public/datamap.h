//========= Copyright 1996-2005, Valve Corporation, All rights reserved. ============//
//
// Purpose: 
//
// $NoKeywords: $
//=============================================================================//

#ifndef DATAMAP_H
#define DATAMAP_H
#ifdef _WIN32
#pragma once
#endif

#ifndef VECTOR_H
#include "mathlib/vector.h"
#endif

#include "tier1/utlvector.h"

#include "tier0/memdbgon.h"

// SINGLE_INHERITANCE restricts the size of CBaseEntity pointers-to-member-functions to 4 bytes
class SINGLE_INHERITANCE CBaseEntity;
struct inputdata_t;

#define INVALID_TIME (FLT_MAX * -1.0) // Special value not rebased on save/load

typedef enum _fieldtypes : uint8
{
	FIELD_VOID = 0,			// No type or value
	FIELD_FLOAT32,			// Any floating point value
	FIELD_STRING,			// A string ID (return from ALLOC_STRING)
	FIELD_VECTOR,			// Any vector, QAngle, or AngularImpulse
	FIELD_QUATERNION,		// A quaternion
	FIELD_INT32,			// Any integer or enum
	FIELD_BOOLEAN,			// boolean, implemented as an int, I may use this as a hint for compression
	FIELD_INT16,			// 2 byte integer
	FIELD_CHARACTER,		// a byte
	FIELD_COLOR32,			// 8-bit per channel r,g,b,a (32bit color)
	FIELD_EMBEDDED,			// an embedded object with a datadesc, recursively traverse and embedded class/structure based on an additional typedescription
	FIELD_CUSTOM,			// special type that contains function pointers to it's read/write/parse functions

	FIELD_CLASSPTR,			// CBaseEntity *
	FIELD_EHANDLE,			// Entity handle

	FIELD_POSITION_VECTOR,	// A world coordinate (these are fixed up across level transitions automagically)
	FIELD_TIME,				// a floating point time (these are fixed up automatically too!)
	FIELD_TICK,				// an integer tick count( fixed up similarly to time)
	FIELD_SOUNDNAME,		// Engine string that is a sound name (needs precache)

	FIELD_INPUT,			// a list of inputed data fields (all derived from CMultiInputVar)
	FIELD_FUNCTION,			// A class function pointer (Think, Use, etc)

	FIELD_VMATRIX,			// a vmatrix (output coords are NOT worldspace)

	// NOTE: Use float arrays for local transformations that don't need to be fixed up.
	FIELD_VMATRIX_WORLDSPACE,// A VMatrix that maps some local space to world space (translation is fixed up on level transitions)
	FIELD_MATRIX3X4_WORLDSPACE,	// matrix3x4_t that maps some local space to world space (translation is fixed up on level transitions)

	FIELD_INTERVAL,			// a start and range floating point interval ( e.g., 3.2->3.6 == 3.2 and 0.4 )
	FIELD_UNUSED,

	FIELD_VECTOR2D,			// 2 floats
	FIELD_INT64,			// 64bit integer

	FIELD_VECTOR4D,			// 4 floats

	FIELD_RESOURCE,

	FIELD_TYPEUNKNOWN,

	FIELD_CSTRING,
	FIELD_HSCRIPT,
	FIELD_VARIANT,
	FIELD_UINT64,
	FIELD_FLOAT64,
	FIELD_POSITIVEINTEGER_OR_NULL,
	FIELD_HSCRIPT_NEW_INSTANCE,
	FIELD_UINT32,
	FIELD_UTLSTRINGTOKEN,
	FIELD_QANGLE,
	FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_VECTOR,
	FIELD_HMATERIAL,
	FIELD_HMODEL,
	FIELD_NETWORK_QUANTIZED_VECTOR,
	FIELD_NETWORK_QUANTIZED_FLOAT,
	FIELD_DIRECTION_VECTOR_WORLDSPACE,
	FIELD_QANGLE_WORLDSPACE,
	FIELD_QUATERNION_WORLDSPACE,
	FIELD_HSCRIPT_LIGHTBINDING,
	FIELD_V8_VALUE,
	FIELD_V8_OBJECT,
	FIELD_V8_ARRAY,
	FIELD_V8_CALLBACK_INFO,
	FIELD_UTLSTRING,

	FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_POSITION_VECTOR,
	FIELD_HRENDERTEXTURE,

	FIELD_HPARTICLESYSTEMDEFINITION,
	FIELD_UINT8,
	FIELD_UINT16,
	FIELD_CTRANSFORM,
	FIELD_CTRANSFORM_WORLDSPACE,
	FIELD_HPOSTPROCESSING,
	FIELD_MATRIX3X4,
	FIELD_SHIM,
	FIELD_CMOTIONTRANSFORM,
	FIELD_CMOTIONTRANSFORM_WORLDSPACE,
	FIELD_ATTACHMENT_HANDLE,
	FIELD_AMMO_INDEX,
	FIELD_CONDITION_ID,
	FIELD_AI_SCHEDULE_BITS,
	FIELD_MODIFIER_HANDLE,
	FIELD_ROTATION_VECTOR,
	FIELD_ROTATION_VECTOR_WORLDSPACE,
	FIELD_HVDATA,
	FIELD_SCALE32,
	FIELD_STRING_AND_TOKEN,
	FIELD_ENGINE_TIME,
	FIELD_ENGINE_TICK,
	FIELD_WORLD_GROUP_ID,
	FIELD_GLOBALSYMBOL,
	
	FIELD_TYPECOUNT
} fieldtype_t;


//-----------------------------------------------------------------------------
// Field sizes... 
//-----------------------------------------------------------------------------
template <int FIELD_TYPE>
class CDatamapFieldSizeDeducer
{
public:
	enum
	{
		SIZE = 0
	};

	static int FieldSize( )
	{
		return 0;
	}
};

#define DECLARE_FIELD_SIZE( _fieldType, _fieldSize )	\
	template< > class CDatamapFieldSizeDeducer<_fieldType> { public: enum { SIZE = _fieldSize }; static int FieldSize() { return _fieldSize; } };
#define FIELD_SIZE( _fieldType )	CDatamapFieldSizeDeducer<_fieldType>::SIZE
#define FIELD_BITS( _fieldType )	(FIELD_SIZE( _fieldType ) * 8)

DECLARE_FIELD_SIZE( FIELD_FLOAT32,		sizeof(float32))
DECLARE_FIELD_SIZE( FIELD_STRING,		sizeof(int))
DECLARE_FIELD_SIZE( FIELD_VECTOR,		3 * sizeof(float32))
DECLARE_FIELD_SIZE( FIELD_VECTOR2D,		2 * sizeof(float32))
DECLARE_FIELD_SIZE( FIELD_VECTOR4D,		4 * sizeof(float32))
DECLARE_FIELD_SIZE( FIELD_QUATERNION,	4 * sizeof(float32))
DECLARE_FIELD_SIZE( FIELD_INT32,		sizeof(int32))
DECLARE_FIELD_SIZE( FIELD_INT64,		sizeof(int64))
DECLARE_FIELD_SIZE( FIELD_BOOLEAN,		sizeof(char))
DECLARE_FIELD_SIZE( FIELD_INT16,		sizeof(int16))
DECLARE_FIELD_SIZE( FIELD_CHARACTER,	sizeof(char))
DECLARE_FIELD_SIZE( FIELD_COLOR32,		sizeof(int))
DECLARE_FIELD_SIZE( FIELD_CLASSPTR,		sizeof(int))
DECLARE_FIELD_SIZE( FIELD_EHANDLE,		sizeof(int))
DECLARE_FIELD_SIZE( FIELD_POSITION_VECTOR, 	3 * sizeof(float))
DECLARE_FIELD_SIZE( FIELD_TIME,			sizeof(float))
DECLARE_FIELD_SIZE( FIELD_TICK,			sizeof(int))
DECLARE_FIELD_SIZE( FIELD_SOUNDNAME,	sizeof(int))
DECLARE_FIELD_SIZE( FIELD_INPUT,		sizeof(int))
DECLARE_FIELD_SIZE( FIELD_FUNCTION,		sizeof(int *))
DECLARE_FIELD_SIZE( FIELD_VMATRIX,		16 * sizeof(float))
DECLARE_FIELD_SIZE( FIELD_VMATRIX_WORLDSPACE,	16 * sizeof(float))
DECLARE_FIELD_SIZE( FIELD_MATRIX3X4_WORLDSPACE,	12 * sizeof(float))
DECLARE_FIELD_SIZE( FIELD_INTERVAL,		2 * sizeof( float) )  // NOTE:  Must match interval.h definition


#define ARRAYSIZE2D(p)		(sizeof(p)/sizeof(p[0][0]))
#define SIZE_OF_ARRAY(p)	_ARRAYSIZE(p)

#define _FIELD(name,fieldtype,count,flags,mapname,tolerance)		{ fieldtype, #name, offsetof(classNameTypedef, name), count, flags, mapname, NULL, NULL, NULL, sizeof( ((classNameTypedef *)0)->name ), NULL, 0, tolerance }
#define DEFINE_FIELD_NULL	{ FIELD_VOID,0,0,0,0,0,0,0,0}
#define DEFINE_FIELD(name,fieldtype)			_FIELD(name, fieldtype, 1,  FTYPEDESC_SAVE, NULL, 0 )
#define DEFINE_FIELD_NOT_SAVED(name,fieldtype)			_FIELD(name, fieldtype, 1, 0, NULL, 0 )

#define DEFINE_KEYFIELD(name,fieldtype, mapname) _FIELD(name, fieldtype, 1,  FTYPEDESC_KEY | FTYPEDESC_SAVE, mapname, 0 )
#define DEFINE_KEYFIELD_NOT_SAVED(name,fieldtype, mapname)_FIELD(name, fieldtype, 1,  FTYPEDESC_KEY, mapname, 0 )
#define DEFINE_AUTO_ARRAY(name,fieldtype)		_FIELD(name, fieldtype, SIZE_OF_ARRAY(((classNameTypedef *)0)->name), FTYPEDESC_SAVE, NULL, 0 )
#define DEFINE_AUTO_ARRAY_KEYFIELD(name,fieldtype,mapname)		_FIELD(name, fieldtype, SIZE_OF_ARRAY(((classNameTypedef *)0)->name), FTYPEDESC_SAVE, mapname, 0 )
#define DEFINE_ARRAY(name,fieldtype, count)		_FIELD(name, fieldtype, count, FTYPEDESC_SAVE, NULL, 0 )
#define DEFINE_ARRAY_NOT_SAVED(name,fieldtype, count)		_FIELD(name, fieldtype, count, 0, NULL, 0 )
#define DEFINE_ENTITY_FIELD(name,fieldtype)			_FIELD(edict_t, name, fieldtype, 1,  FTYPEDESC_KEY | FTYPEDESC_SAVE, #name, 0 )
#define DEFINE_ENTITY_GLOBAL_FIELD(name,fieldtype)	_FIELD(edict_t, name, fieldtype, 1,  FTYPEDESC_KEY | FTYPEDESC_SAVE | FTYPEDESC_GLOBAL, #name, 0 )
#define DEFINE_GLOBAL_FIELD(name,fieldtype)	_FIELD(name, fieldtype, 1,  FTYPEDESC_GLOBAL | FTYPEDESC_SAVE, NULL, 0 )
#define DEFINE_GLOBAL_KEYFIELD(name,fieldtype, mapname)	_FIELD(name, fieldtype, 1,  FTYPEDESC_GLOBAL | FTYPEDESC_KEY | FTYPEDESC_SAVE, mapname, 0 )
#define DEFINE_CUSTOM_FIELD(name,datafuncs)	{ FIELD_CUSTOM, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE, NULL, datafuncs, NULL }
#define DEFINE_CUSTOM_KEYFIELD(name,datafuncs,mapname)	{ FIELD_CUSTOM, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE | FTYPEDESC_KEY, mapname, datafuncs, NULL }
#define DEFINE_AUTO_ARRAY2D(name,fieldtype)		_FIELD(name, fieldtype, ARRAYSIZE2D(((classNameTypedef *)0)->name), FTYPEDESC_SAVE, NULL, 0 )
// Used by byteswap datadescs
#define DEFINE_BITFIELD(name,fieldtype,bitcount)	DEFINE_ARRAY(name,fieldtype,((bitcount+FIELD_BITS(fieldtype)-1)&~(FIELD_BITS(fieldtype)-1)) / FIELD_BITS(fieldtype) )
#define DEFINE_INDEX(name,fieldtype)			_FIELD(name, fieldtype, 1,  FTYPEDESC_INDEX, NULL, 0 )

#define DEFINE_EMBEDDED( name )						\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE, NULL, NULL, NULL, &(((classNameTypedef *)0)->name.m_DataMap), sizeof( ((classNameTypedef *)0)->name ), NULL, 0, 0.0f }

#define DEFINE_EMBEDDED_OVERRIDE( name, overridetype )	\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE, NULL, NULL, NULL, &((overridetype *)0)->m_DataMap, sizeof( ((classNameTypedef *)0)->name ), NULL, 0, 0.0f }

#define DEFINE_EMBEDDEDBYREF( name )					\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE | FTYPEDESC_PTR, NULL, NULL, NULL, &(((classNameTypedef *)0)->name->m_DataMap), sizeof( *(((classNameTypedef *)0)->name) ), NULL, 0, 0.0f }

#define DEFINE_EMBEDDED_ARRAY( name, count )			\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), count, FTYPEDESC_SAVE, NULL, NULL, NULL, &(((classNameTypedef *)0)->name->m_DataMap), sizeof( ((classNameTypedef *)0)->name[0] ), NULL, 0, 0.0f  }

#define DEFINE_EMBEDDED_AUTO_ARRAY( name )			\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), SIZE_OF_ARRAY( ((classNameTypedef *)0)->name ), FTYPEDESC_SAVE, NULL, NULL, NULL, &(((classNameTypedef *)0)->name->m_DataMap), sizeof( ((classNameTypedef *)0)->name[0] ), NULL, 0, 0.0f  }

#ifndef NO_ENTITY_PREDICTION

// FTYPEDESC_KEY tells the prediction copy system to report the full nameof the field when reporting errors
#define DEFINE_PRED_TYPEDESCRIPTION( name, fieldtype )						\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE | FTYPEDESC_KEY, NULL, NULL, NULL, &fieldtype::m_PredMap }

#define DEFINE_PRED_TYPEDESCRIPTION_PTR( name, fieldtype )						\
	{ FIELD_EMBEDDED, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_SAVE | FTYPEDESC_PTR | FTYPEDESC_KEY, NULL, NULL, NULL, &fieldtype::m_PredMap }

#else

#define DEFINE_PRED_TYPEDESCRIPTION( name, fieldtype )		DEFINE_FIELD_NULL
#define DEFINE_PRED_TYPEDESCRIPTION_PTR( name, fieldtype )	DEFINE_FIELD_NULL

#endif

// Extensions to datamap.h macros for predicted entities only
#define DEFINE_PRED_FIELD(name,fieldtype, flags)			_FIELD(name, fieldtype, 1,  flags, NULL, 0.0f )
#define DEFINE_PRED_ARRAY(name,fieldtype, count,flags)		_FIELD(name, fieldtype, count, flags, NULL, 0.0f )
#define DEFINE_FIELD_NAME(localname,netname,fieldtype)		_FIELD(localname, fieldtype, 1,  0, #netname, 0.0f )
// Predictable macros, which include a tolerance for floating point values...
#define DEFINE_PRED_FIELD_TOL(name,fieldtype, flags,tolerance)			_FIELD(name, fieldtype, 1,  flags, NULL, tolerance )
#define DEFINE_PRED_ARRAY_TOL(name,fieldtype, count,flags,tolerance)		_FIELD(name, fieldtype, count, flags, NULL, tolerance)
#define DEFINE_FIELD_NAME_TOL(localname,netname,fieldtolerance)		_FIELD(localname, fieldtype, 1,  0, #netname, tolerance )

//#define DEFINE_DATA( name, fieldextname, flags ) _FIELD(name, fieldtype, 1,  flags, extname )

// INPUTS
#define DEFINE_INPUT( name, fieldtype, inputname ) { fieldtype, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_INPUT | FTYPEDESC_SAVE | FTYPEDESC_KEY,	inputname, NULL, NULL, NULL, sizeof( ((classNameTypedef *)0)->name ) }
#define DEFINE_INPUTFUNC( fieldtype, inputname, inputfunc ) { fieldtype, #inputfunc, NULL, 1, FTYPEDESC_INPUT, inputname, NULL, static_cast <inputfunc_t> (&classNameTypedef::inputfunc) }

// OUTPUTS
// the variable 'name' MUST BE derived from CBaseOutput
// we know the output type from the variable itself, so it doesn't need to be specified here
class ISaveRestoreOps;
extern ISaveRestoreOps *eventFuncs;
#define DEFINE_OUTPUT( name, outputname )	{ FIELD_CUSTOM, #name, offsetof(classNameTypedef, name), 1, FTYPEDESC_OUTPUT | FTYPEDESC_SAVE | FTYPEDESC_KEY, outputname, eventFuncs }

// replaces EXPORT table for portability and non-DLL based systems (xbox)
#define DEFINE_FUNCTION_RAW( function, func_type )			{ FIELD_VOID, nameHolder.GenerateName(#function), NULL, 1, FTYPEDESC_FUNCTIONTABLE, NULL, NULL, (inputfunc_t)((func_type)(&classNameTypedef::function)) }
#define DEFINE_FUNCTION( function )			DEFINE_FUNCTION_RAW( function, inputfunc_t )


#define FTYPEDESC_NONE				0

#define FTYPEDESC_GLOBAL			(1 << 0)		// This field is masked for global entity save/restore
#define FTYPEDESC_SAVE				(1 << 1)		// This field is saved to disk
#define FTYPEDESC_KEY				(1 << 2)		// This field can be requested and written to by string name at load time
#define FTYPEDESC_INPUT				(1 << 3)		// This field can be written to by string name at run time, and a function called
#define FTYPEDESC_OUTPUT			(1 << 4)		// This field propogates it's value to all targets whenever it changes
#define FTYPEDESC_FUNCTIONTABLE		(1 << 5)		// This is a table entry for a member function pointer
#define FTYPEDESC_PTR				(1 << 6)		// This field is a pointer, not an embedded object
#define FTYPEDESC_OVERRIDE			(1 << 7)		// The field is an override for one in a base class (only used by prediction system for now)

// Flags used by other systems (e.g., prediction system)
#define FTYPEDESC_INSENDTABLE		(1 << 8)		// This field is present in a network SendTable
#define FTYPEDESC_PRIVATE			(1 << 9)		// The field is local to the client or server only (not referenced by prediction code and not replicated by networking)
#define FTYPEDESC_NOERRORCHECK		(1 << 10)		// The field is part of the prediction typedescription, but doesn't get compared when checking for errors

#define FTYPEDESC_MODELINDEX		(1 << 11)		// The field is a model index (used for debugging output)

#define FTYPEDESC_INDEX				(1 << 12)		// The field is an index into file data, used for byteswapping. 

#define FTYPEDESC_OVERRIDE_RECURSIVE	(1 << 13)
#define FTYPEDESC_SCHEMA_INITIALIZED	(1 << 14)
#define FTYPEDESC_GEN_ARRAY_KEYNAMES_0	(1 << 15)
#define FTYPEDESC_GEN_ARRAY_KEYNAMES_1	(1 << 16)
#define FTYPEDESC_ADDITIONAL_FIELDS		(1 << 17)
#define FTYPEDESC_EXPLICIT_BASE			(1 << 18)
#define FTYPEDESC_PROCEDURAL_KEYFIELD	(1 << 19)
#define FTYPEDESC_ENUM					(1 << 20)	// Used if the typedesc is enum, no datamap_t info would be available
#define FTYPEDESC_REMOVED_KEYFIELD		(1 << 21)
#define FTYPEDESC_WAS_INPUT				(1 << 22)
#define FTYPEDESC_WAS_OUTPUT			(1 << 23)

#define TD_MSECTOLERANCE		0.001f		// This is a FIELD_FLOAT and should only be checked to be within 0.001 of the networked info

class ISaveRestoreOps;
class IPredictionCopyOps;

//
// Function prototype for all input handlers.
//
typedef void (CBaseEntity::*inputfunc_t)(inputdata_t &data);

struct datamap_t;

enum PredictionCopyType_t
{
	PC_NON_NETWORKED_ONLY = 0,
	PC_NETWORKED_ONLY,

	PC_COPYTYPE_COUNT,
	PC_EVERYTHING = PC_COPYTYPE_COUNT,
};

enum TypedescriptionOffsetType_t
{
	TD_OFFSET_NORMAL = 0,
	TD_OFFSET_PACKED = 1,

	// Must be last
	TD_OFFSET_COUNT,
};

struct typedescription_t
{
	fieldtype_t			fieldType;
	const char			*fieldName;
	int					fieldOffset; // Local offset value
	unsigned short		fieldSize;
	int					flags;
	// the name of the variable in the map/fgd data, or the name of the action
	const char			*externalName;	
	// pointer to the function set for save/restoring of custom data types
	ISaveRestoreOps		*pSaveRestoreOps; 
	// for associating function with string names
	inputfunc_t			inputFunc; 

	// For embedding additional datatables inside this one
	union
	{
		datamap_t* td;
		const char* enumName;
	};

	// Stores the actual member variable size in bytes
	int					fieldSizeInBytes;
  
	// Tolerance for field errors for float fields
	float				fieldTolerance;

	// For raw fields (including children of embedded stuff) this is the flattened offset
	int					flatOffset[ TD_OFFSET_COUNT ];
	unsigned short		flatGroup;

	IPredictionCopyOps*	pPredictionCopyOps;
	datamap_t*			m_pPredictionCopyDataMap;
};

// See predictioncopy.h for implementation and notes
struct optimized_datamap_t;

//-----------------------------------------------------------------------------
// Purpose: stores the list of objects in the hierarchy
//			used to iterate through an object's data descriptions
//-----------------------------------------------------------------------------
struct datamap_t
{
	typedescription_t	*dataDesc;
	int					dataNumFields;
	char const			*dataClassName;
	datamap_t			*baseMap;

	optimized_datamap_t	*m_pOptimizedDataMap;
	int					m_nPackedSize;
	
#if defined( _DEBUG )
	bool				bValidityChecked;
#endif // _DEBUG
};


//-----------------------------------------------------------------------------
//
// Macros used to implement datadescs
//
#define DECLARE_FRIEND_DATADESC_ACCESS()	\
	template <typename T> friend void DataMapAccess(T *, datamap_t **p); \
	template <typename T> friend datamap_t *DataMapInit(T *);

#define DECLARE_SIMPLE_DATADESC() \
	static datamap_t m_DataMap; \
	static datamap_t *GetBaseMap(); \
	template <typename T> friend void DataMapAccess(T *, datamap_t **p); \
	template <typename T> friend datamap_t *DataMapInit(T *);

#define DECLARE_SIMPLE_DATADESC_INSIDE_NAMESPACE() \
	static datamap_t m_DataMap; \
	static datamap_t *GetBaseMap(); \
	template <typename T> friend void ::DataMapAccess(T *, datamap_t **p); \
	template <typename T> friend datamap_t *::DataMapInit(T *);

#define	DECLARE_DATADESC() \
	DECLARE_SIMPLE_DATADESC() \
	virtual datamap_t *GetDataDescMap( void );

#define BEGIN_DATADESC( className ) \
	datamap_t className::m_DataMap = { 0, 0, #className, NULL }; \
	datamap_t *className::GetDataDescMap( void ) { return &m_DataMap; } \
	datamap_t *className::GetBaseMap() { datamap_t *pResult; DataMapAccess((BaseClass *)NULL, &pResult); return pResult; } \
	BEGIN_DATADESC_GUTS( className )

#define BEGIN_DATADESC_NO_BASE( className ) \
	datamap_t className::m_DataMap = { 0, 0, #className, NULL }; \
	datamap_t *className::GetDataDescMap( void ) { return &m_DataMap; } \
	datamap_t *className::GetBaseMap() { return NULL; } \
	BEGIN_DATADESC_GUTS( className )

#define BEGIN_SIMPLE_DATADESC( className ) \
	datamap_t className::m_DataMap = { 0, 0, #className, NULL }; \
	datamap_t *className::GetBaseMap() { return NULL; } \
	BEGIN_DATADESC_GUTS( className )

#define BEGIN_SIMPLE_DATADESC_( className, BaseClass ) \
	datamap_t className::m_DataMap = { 0, 0, #className, NULL }; \
	datamap_t *className::GetBaseMap() { datamap_t *pResult; DataMapAccess((BaseClass *)NULL, &pResult); return pResult; } \
	BEGIN_DATADESC_GUTS( className )

#define BEGIN_DATADESC_GUTS( className ) \
	template <typename T> datamap_t *DataMapInit(T *); \
	template <> datamap_t *DataMapInit<className>( className * ); \
	namespace className##_DataDescInit \
	{ \
		datamap_t *g_DataMapHolder = DataMapInit( (className *)NULL ); /* This can/will be used for some clean up duties later */ \
	} \
	\
	template <> datamap_t *DataMapInit<className>( className * ) \
	{ \
		typedef className classNameTypedef; \
		static CDatadescGeneratedNameHolder nameHolder(#className); \
		className::m_DataMap.baseMap = className::GetBaseMap(); \
		static typedescription_t dataDesc[] = \
		{ \
		{ FIELD_VOID,0,0,0,0,0,0,0,0}, /* so you can define "empty" tables */


#define BEGIN_DATADESC_GUTS_NAMESPACE( className, nameSpace ) \
	template <typename T> datamap_t *nameSpace::DataMapInit(T *); \
	template <> datamap_t *nameSpace::DataMapInit<className>( className * ); \
	namespace className##_DataDescInit \
	{ \
		datamap_t *g_DataMapHolder = nameSpace::DataMapInit( (className *)NULL ); /* This can/will be used for some clean up duties later */ \
	} \
	\
	template <> datamap_t *nameSpace::DataMapInit<className>( className * ) \
	{ \
		typedef className classNameTypedef; \
		static CDatadescGeneratedNameHolder nameHolder(#className); \
		className::m_DataMap.baseMap = className::GetBaseMap(); \
		static typedescription_t dataDesc[] = \
		{ \
		{ FIELD_VOID,0,0,0,0,0,0,0,0}, /* so you can define "empty" tables */

#define END_DATADESC() \
		}; \
		\
		if ( sizeof( dataDesc ) > sizeof( dataDesc[0] ) ) \
		{ \
			classNameTypedef::m_DataMap.dataNumFields = SIZE_OF_ARRAY( dataDesc ) - 1; \
			classNameTypedef::m_DataMap.dataDesc 	  = &dataDesc[1]; \
		} \
		else \
		{ \
			classNameTypedef::m_DataMap.dataNumFields = 1; \
			classNameTypedef::m_DataMap.dataDesc 	  = dataDesc; \
		} \
		return &classNameTypedef::m_DataMap; \
	}

// used for when there is no data description
#define IMPLEMENT_NULL_SIMPLE_DATADESC( derivedClass ) \
	BEGIN_SIMPLE_DATADESC( derivedClass ) \
	END_DATADESC()

#define IMPLEMENT_NULL_SIMPLE_DATADESC_( derivedClass, baseClass ) \
	BEGIN_SIMPLE_DATADESC_( derivedClass, baseClass ) \
	END_DATADESC()

#define IMPLEMENT_NULL_DATADESC( derivedClass ) \
	BEGIN_DATADESC( derivedClass ) \
	END_DATADESC()

// helps get the offset of a bitfield
#define BEGIN_BITFIELD( name ) \
	union \
	{ \
		char name; \
		struct \
		{

#define END_BITFIELD() \
		}; \
	};

//-----------------------------------------------------------------------------
// Forward compatability with potential seperate byteswap datadescs

#define DECLARE_BYTESWAP_DATADESC() DECLARE_SIMPLE_DATADESC()
#define BEGIN_BYTESWAP_DATADESC(name) BEGIN_SIMPLE_DATADESC(name) 
#define BEGIN_BYTESWAP_DATADESC_(name,base) BEGIN_SIMPLE_DATADESC_(name,base) 
#define END_BYTESWAP_DATADESC() END_DATADESC()

//-----------------------------------------------------------------------------

template <typename T> 
inline void DataMapAccess(T *ignored, datamap_t **p)
{
	*p = &T::m_DataMap;
}

//-----------------------------------------------------------------------------

class CDatadescGeneratedNameHolder
{
public:
	CDatadescGeneratedNameHolder( const char *pszBase )
	 : m_pszBase(pszBase)
	{
		m_nLenBase = strlen( m_pszBase );
	}
	
	~CDatadescGeneratedNameHolder()
	{
		for ( int i = 0; i < m_Names.Count(); i++ )
		{
			delete m_Names[i];
		}
	}
	
	const char *GenerateName( const char *pszIdentifier )
	{
		char *pBuf = new char[m_nLenBase + strlen(pszIdentifier) + 1];
		strcpy( pBuf, m_pszBase );
		strcat( pBuf, pszIdentifier );
		m_Names.AddToTail( pBuf );
		return pBuf;
	}
	
private:
	const char *m_pszBase;
	size_t m_nLenBase;
	CUtlVector<char *> m_Names;
};

//-----------------------------------------------------------------------------

#include "tier0/memdbgoff.h"

#endif // DATAMAP_H
