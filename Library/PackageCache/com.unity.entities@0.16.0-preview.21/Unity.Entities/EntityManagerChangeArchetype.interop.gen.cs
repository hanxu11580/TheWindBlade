
//------------------------------------------------------------------------------
// <auto-generated>
//     This file was automatically generated by Unity.Entities.Editor.BurstInteropCodeGenerator
//     Any changes you make here will be overwritten
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     To update this file, use the "DOTS -> Regenerate Burst Interop" menu option.
//
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Unity.Burst;
using Unity.Collections;
using System.Runtime.InteropServices;

namespace Unity.Entities
{
     unsafe partial struct StructuralChange
    {

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)

        [BurstDiscard]
        private static void CheckDelegate(ref bool useDelegate)
        {
            //@TODO: This should use BurstCompiler.IsEnabled once that is available as an efficient API.
            useDelegate = true;
        }

        private static bool UseDelegate()
        {
            bool result = false;
            CheckDelegate(ref result);
            return result;
        }

        static class Managed
        {
            public static bool _initialized = false;

            public delegate void _dlg_AddComponentEntitiesBatch(IntPtr entityComponentStore, IntPtr entityBatchList, int typeIndex);
            public static _dlg_AddComponentEntitiesBatch _bfp_AddComponentEntitiesBatch;
            public delegate bool _dlg_AddComponentEntity(IntPtr entityComponentStore, IntPtr entity, int typeIndex);
            public static _dlg_AddComponentEntity _bfp_AddComponentEntity;
            public delegate void _dlg_AddComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int typeIndex);
            public static _dlg_AddComponentChunks _bfp_AddComponentChunks;
            public delegate void _dlg_AddComponentsChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, ref ComponentTypes types);
            public static _dlg_AddComponentsChunks _bfp_AddComponentsChunks;
            public delegate bool _dlg_RemoveComponentEntity(IntPtr entityComponentStore, IntPtr entity, int typeIndex);
            public static _dlg_RemoveComponentEntity _bfp_RemoveComponentEntity;
            public delegate void _dlg_RemoveComponentEntitiesBatch(IntPtr entityComponentStore, IntPtr entityBatchList, int typeIndex);
            public static _dlg_RemoveComponentEntitiesBatch _bfp_RemoveComponentEntitiesBatch;
            public delegate void _dlg_RemoveComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int typeIndex);
            public static _dlg_RemoveComponentChunks _bfp_RemoveComponentChunks;
            public delegate void _dlg_RemoveComponentsChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, ref ComponentTypes types);
            public static _dlg_RemoveComponentsChunks _bfp_RemoveComponentsChunks;
            public delegate void _dlg_AddSharedComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int componentTypeIndex, int sharedComponentIndex);
            public static _dlg_AddSharedComponentChunks _bfp_AddSharedComponentChunks;
            public delegate void _dlg_MoveEntityArchetype(IntPtr entityComponentStore, IntPtr entity, IntPtr dstArchetype);
            public static _dlg_MoveEntityArchetype _bfp_MoveEntityArchetype;
            public delegate void _dlg_SetChunkComponent(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, IntPtr componentData, int componentTypeIndex);
            public static _dlg_SetChunkComponent _bfp_SetChunkComponent;
            public delegate void _dlg_CreateEntity(IntPtr entityComponentStore, IntPtr archetype, IntPtr outEntities, int count);
            public static _dlg_CreateEntity _bfp_CreateEntity;
            public delegate void _dlg_InstantiateEntities(IntPtr entityComponentStore, IntPtr srcEntity, IntPtr outputEntities, int instanceCount);
            public static _dlg_InstantiateEntities _bfp_InstantiateEntities;
        }


#endif

        [NotBurstCompatible]
        internal static void Initialize()
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (Managed._initialized)
                return;
            Managed._initialized = true;
            Managed._bfp_AddComponentEntitiesBatch = BurstCompiler.CompileFunctionPointer<Managed._dlg_AddComponentEntitiesBatch>(_mono_to_burst_AddComponentEntitiesBatch).Invoke;
            Managed._bfp_AddComponentEntity = BurstCompiler.CompileFunctionPointer<Managed._dlg_AddComponentEntity>(_mono_to_burst_AddComponentEntity).Invoke;
            Managed._bfp_AddComponentChunks = BurstCompiler.CompileFunctionPointer<Managed._dlg_AddComponentChunks>(_mono_to_burst_AddComponentChunks).Invoke;
            Managed._bfp_AddComponentsChunks = BurstCompiler.CompileFunctionPointer<Managed._dlg_AddComponentsChunks>(_mono_to_burst_AddComponentsChunks).Invoke;
            Managed._bfp_RemoveComponentEntity = BurstCompiler.CompileFunctionPointer<Managed._dlg_RemoveComponentEntity>(_mono_to_burst_RemoveComponentEntity).Invoke;
            Managed._bfp_RemoveComponentEntitiesBatch = BurstCompiler.CompileFunctionPointer<Managed._dlg_RemoveComponentEntitiesBatch>(_mono_to_burst_RemoveComponentEntitiesBatch).Invoke;
            Managed._bfp_RemoveComponentChunks = BurstCompiler.CompileFunctionPointer<Managed._dlg_RemoveComponentChunks>(_mono_to_burst_RemoveComponentChunks).Invoke;
            Managed._bfp_RemoveComponentsChunks = BurstCompiler.CompileFunctionPointer<Managed._dlg_RemoveComponentsChunks>(_mono_to_burst_RemoveComponentsChunks).Invoke;
            Managed._bfp_AddSharedComponentChunks = BurstCompiler.CompileFunctionPointer<Managed._dlg_AddSharedComponentChunks>(_mono_to_burst_AddSharedComponentChunks).Invoke;
            Managed._bfp_MoveEntityArchetype = BurstCompiler.CompileFunctionPointer<Managed._dlg_MoveEntityArchetype>(_mono_to_burst_MoveEntityArchetype).Invoke;
            Managed._bfp_SetChunkComponent = BurstCompiler.CompileFunctionPointer<Managed._dlg_SetChunkComponent>(_mono_to_burst_SetChunkComponent).Invoke;
            Managed._bfp_CreateEntity = BurstCompiler.CompileFunctionPointer<Managed._dlg_CreateEntity>(_mono_to_burst_CreateEntity).Invoke;
            Managed._bfp_InstantiateEntities = BurstCompiler.CompileFunctionPointer<Managed._dlg_InstantiateEntities>(_mono_to_burst_InstantiateEntities).Invoke;

#endif
        }

        public  static void AddComponentEntitiesBatch (EntityComponentStore* entityComponentStore, Unity.Collections.LowLevel.Unsafe.UnsafeList* entityBatchList, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_AddComponentEntitiesBatch(entityComponentStore, entityBatchList, typeIndex);
                return;
            }
#endif

            _AddComponentEntitiesBatch(entityComponentStore, entityBatchList, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_AddComponentEntitiesBatch))]
        private static void _mono_to_burst_AddComponentEntitiesBatch(IntPtr entityComponentStore, IntPtr entityBatchList, int typeIndex)
        {
            _AddComponentEntitiesBatch((EntityComponentStore*)entityComponentStore, (Unity.Collections.LowLevel.Unsafe.UnsafeList*)entityBatchList, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_AddComponentEntitiesBatch(EntityComponentStore* entityComponentStore, Unity.Collections.LowLevel.Unsafe.UnsafeList* entityBatchList, int typeIndex)
        {
            Managed._bfp_AddComponentEntitiesBatch((IntPtr) entityComponentStore, (IntPtr) entityBatchList, typeIndex);
        }
#endif

        public  static bool AddComponentEntity (EntityComponentStore* entityComponentStore, Entity* entity, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                var _retval = default(bool);
                _forward_mono_AddComponentEntity(ref _retval, entityComponentStore, entity, typeIndex);
                return _retval;
            }
#endif

            return _AddComponentEntity(entityComponentStore, entity, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_AddComponentEntity))]
        private static bool _mono_to_burst_AddComponentEntity(IntPtr entityComponentStore, IntPtr entity, int typeIndex)
        {
            return _AddComponentEntity((EntityComponentStore*)entityComponentStore, (Entity*)entity, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_AddComponentEntity(ref bool _retval, EntityComponentStore* entityComponentStore, Entity* entity, int typeIndex)
        {
            _retval = Managed._bfp_AddComponentEntity((IntPtr) entityComponentStore, (IntPtr) entity, typeIndex);
        }
#endif

        public  static void AddComponentChunks (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_AddComponentChunks(entityComponentStore, chunks, chunkCount, typeIndex);
                return;
            }
#endif

            _AddComponentChunks(entityComponentStore, chunks, chunkCount, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_AddComponentChunks))]
        private static void _mono_to_burst_AddComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int typeIndex)
        {
            _AddComponentChunks((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_AddComponentChunks(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int typeIndex)
        {
            Managed._bfp_AddComponentChunks((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, typeIndex);
        }
#endif

        public  static void AddComponentsChunks (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, ref ComponentTypes types)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_AddComponentsChunks(entityComponentStore, chunks, chunkCount, ref types);
                return;
            }
#endif

            _AddComponentsChunks(entityComponentStore, chunks, chunkCount, ref types);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_AddComponentsChunks))]
        private static void _mono_to_burst_AddComponentsChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, ref ComponentTypes types)
        {
            _AddComponentsChunks((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, ref types);
        }

        [BurstDiscard]
        private static void _forward_mono_AddComponentsChunks(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, ref ComponentTypes types)
        {
            Managed._bfp_AddComponentsChunks((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, ref types);
        }
#endif

        public  static bool RemoveComponentEntity (EntityComponentStore* entityComponentStore, Entity* entity, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                var _retval = default(bool);
                _forward_mono_RemoveComponentEntity(ref _retval, entityComponentStore, entity, typeIndex);
                return _retval;
            }
#endif

            return _RemoveComponentEntity(entityComponentStore, entity, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_RemoveComponentEntity))]
        private static bool _mono_to_burst_RemoveComponentEntity(IntPtr entityComponentStore, IntPtr entity, int typeIndex)
        {
            return _RemoveComponentEntity((EntityComponentStore*)entityComponentStore, (Entity*)entity, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_RemoveComponentEntity(ref bool _retval, EntityComponentStore* entityComponentStore, Entity* entity, int typeIndex)
        {
            _retval = Managed._bfp_RemoveComponentEntity((IntPtr) entityComponentStore, (IntPtr) entity, typeIndex);
        }
#endif

        public  static void RemoveComponentEntitiesBatch (EntityComponentStore* entityComponentStore, Unity.Collections.LowLevel.Unsafe.UnsafeList* entityBatchList, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_RemoveComponentEntitiesBatch(entityComponentStore, entityBatchList, typeIndex);
                return;
            }
#endif

            _RemoveComponentEntitiesBatch(entityComponentStore, entityBatchList, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_RemoveComponentEntitiesBatch))]
        private static void _mono_to_burst_RemoveComponentEntitiesBatch(IntPtr entityComponentStore, IntPtr entityBatchList, int typeIndex)
        {
            _RemoveComponentEntitiesBatch((EntityComponentStore*)entityComponentStore, (Unity.Collections.LowLevel.Unsafe.UnsafeList*)entityBatchList, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_RemoveComponentEntitiesBatch(EntityComponentStore* entityComponentStore, Unity.Collections.LowLevel.Unsafe.UnsafeList* entityBatchList, int typeIndex)
        {
            Managed._bfp_RemoveComponentEntitiesBatch((IntPtr) entityComponentStore, (IntPtr) entityBatchList, typeIndex);
        }
#endif

        public  static void RemoveComponentChunks (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int typeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_RemoveComponentChunks(entityComponentStore, chunks, chunkCount, typeIndex);
                return;
            }
#endif

            _RemoveComponentChunks(entityComponentStore, chunks, chunkCount, typeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_RemoveComponentChunks))]
        private static void _mono_to_burst_RemoveComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int typeIndex)
        {
            _RemoveComponentChunks((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, typeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_RemoveComponentChunks(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int typeIndex)
        {
            Managed._bfp_RemoveComponentChunks((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, typeIndex);
        }
#endif

        public  static void RemoveComponentsChunks (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, ref ComponentTypes types)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_RemoveComponentsChunks(entityComponentStore, chunks, chunkCount, ref types);
                return;
            }
#endif

            _RemoveComponentsChunks(entityComponentStore, chunks, chunkCount, ref types);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_RemoveComponentsChunks))]
        private static void _mono_to_burst_RemoveComponentsChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, ref ComponentTypes types)
        {
            _RemoveComponentsChunks((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, ref types);
        }

        [BurstDiscard]
        private static void _forward_mono_RemoveComponentsChunks(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, ref ComponentTypes types)
        {
            Managed._bfp_RemoveComponentsChunks((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, ref types);
        }
#endif

        public  static void AddSharedComponentChunks (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int componentTypeIndex, int sharedComponentIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_AddSharedComponentChunks(entityComponentStore, chunks, chunkCount, componentTypeIndex, sharedComponentIndex);
                return;
            }
#endif

            _AddSharedComponentChunks(entityComponentStore, chunks, chunkCount, componentTypeIndex, sharedComponentIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_AddSharedComponentChunks))]
        private static void _mono_to_burst_AddSharedComponentChunks(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, int componentTypeIndex, int sharedComponentIndex)
        {
            _AddSharedComponentChunks((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, componentTypeIndex, sharedComponentIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_AddSharedComponentChunks(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, int componentTypeIndex, int sharedComponentIndex)
        {
            Managed._bfp_AddSharedComponentChunks((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, componentTypeIndex, sharedComponentIndex);
        }
#endif

        public  static void MoveEntityArchetype (EntityComponentStore* entityComponentStore, Entity* entity, void* dstArchetype)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_MoveEntityArchetype(entityComponentStore, entity, dstArchetype);
                return;
            }
#endif

            _MoveEntityArchetype(entityComponentStore, entity, dstArchetype);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_MoveEntityArchetype))]
        private static void _mono_to_burst_MoveEntityArchetype(IntPtr entityComponentStore, IntPtr entity, IntPtr dstArchetype)
        {
            _MoveEntityArchetype((EntityComponentStore*)entityComponentStore, (Entity*)entity, (void*)dstArchetype);
        }

        [BurstDiscard]
        private static void _forward_mono_MoveEntityArchetype(EntityComponentStore* entityComponentStore, Entity* entity, void* dstArchetype)
        {
            Managed._bfp_MoveEntityArchetype((IntPtr) entityComponentStore, (IntPtr) entity, (IntPtr) dstArchetype);
        }
#endif

        public  static void SetChunkComponent (EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, void* componentData, int componentTypeIndex)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_SetChunkComponent(entityComponentStore, chunks, chunkCount, componentData, componentTypeIndex);
                return;
            }
#endif

            _SetChunkComponent(entityComponentStore, chunks, chunkCount, componentData, componentTypeIndex);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_SetChunkComponent))]
        private static void _mono_to_burst_SetChunkComponent(IntPtr entityComponentStore, IntPtr chunks, int chunkCount, IntPtr componentData, int componentTypeIndex)
        {
            _SetChunkComponent((EntityComponentStore*)entityComponentStore, (ArchetypeChunk*)chunks, chunkCount, (void*)componentData, componentTypeIndex);
        }

        [BurstDiscard]
        private static void _forward_mono_SetChunkComponent(EntityComponentStore* entityComponentStore, ArchetypeChunk* chunks, int chunkCount, void* componentData, int componentTypeIndex)
        {
            Managed._bfp_SetChunkComponent((IntPtr) entityComponentStore, (IntPtr) chunks, chunkCount, (IntPtr) componentData, componentTypeIndex);
        }
#endif

        public  static void CreateEntity (EntityComponentStore* entityComponentStore, void* archetype, Entity* outEntities, int count)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_CreateEntity(entityComponentStore, archetype, outEntities, count);
                return;
            }
#endif

            _CreateEntity(entityComponentStore, archetype, outEntities, count);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_CreateEntity))]
        private static void _mono_to_burst_CreateEntity(IntPtr entityComponentStore, IntPtr archetype, IntPtr outEntities, int count)
        {
            _CreateEntity((EntityComponentStore*)entityComponentStore, (void*)archetype, (Entity*)outEntities, count);
        }

        [BurstDiscard]
        private static void _forward_mono_CreateEntity(EntityComponentStore* entityComponentStore, void* archetype, Entity* outEntities, int count)
        {
            Managed._bfp_CreateEntity((IntPtr) entityComponentStore, (IntPtr) archetype, (IntPtr) outEntities, count);
        }
#endif

        public  static void InstantiateEntities (EntityComponentStore* entityComponentStore, Entity* srcEntity, Entity* outputEntities, int instanceCount)
        {
#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
            if (UseDelegate())
            {
                _forward_mono_InstantiateEntities(entityComponentStore, srcEntity, outputEntities, instanceCount);
                return;
            }
#endif

            _InstantiateEntities(entityComponentStore, srcEntity, outputEntities, instanceCount);
        }

#if !(UNITY_2020_1_OR_NEWER && UNITY_IOS)
        [BurstCompile]
        [MonoPInvokeCallback(typeof(Managed._dlg_InstantiateEntities))]
        private static void _mono_to_burst_InstantiateEntities(IntPtr entityComponentStore, IntPtr srcEntity, IntPtr outputEntities, int instanceCount)
        {
            _InstantiateEntities((EntityComponentStore*)entityComponentStore, (Entity*)srcEntity, (Entity*)outputEntities, instanceCount);
        }

        [BurstDiscard]
        private static void _forward_mono_InstantiateEntities(EntityComponentStore* entityComponentStore, Entity* srcEntity, Entity* outputEntities, int instanceCount)
        {
            Managed._bfp_InstantiateEntities((IntPtr) entityComponentStore, (IntPtr) srcEntity, (IntPtr) outputEntities, instanceCount);
        }
#endif




    }
}