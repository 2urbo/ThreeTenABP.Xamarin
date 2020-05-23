using System;
using Android.Runtime;
using Java.Interop;

namespace Org.Threeten.BP
{
    public partial class LocalDate
    {
        public override global::System.Int32 CompareTo(global::Java.Lang.Object o)
        {
            return o.GetHashCode().Equals(GetHashCode()) ? 0 : -1;
        }

        [Register("until", "(Lorg/threeten/bp/chrono/ChronoLocalDate;)Lorg/threeten/bp/Period;", "")]
        public override unsafe global::Org.Threeten.BP.Chrono.ChronoPeriod Until(global::Org.Threeten.BP.Chrono.ChronoLocalDate endDate)
        {
            const string __id = "until.(Lorg/threeten/bp/chrono/ChronoLocalDate;)Lorg/threeten/bp/Period;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((endDate == null) ? IntPtr.Zero : ((global::Java.Lang.Object)endDate).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Chrono.ChronoPeriod>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("plus", "(JLorg/threeten/bp/temporal/TemporalUnit;)Lorg/threeten/bp/LocalDate;", "")]
        public override unsafe global::Org.Threeten.BP.Chrono.ChronoLocalDate Plus(long amountToAdd, global::Org.Threeten.BP.Temporal.ITemporalUnit unit)
        {
            const string __id = "plus.(JLorg/threeten/bp/temporal/TemporalUnit;)Lorg/threeten/bp/LocalDate;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(amountToAdd);
                __args[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Chrono.ChronoLocalDate>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public partial class LocalDateTime
    {
        public override global::System.Int32 CompareTo(global::Java.Lang.Object o)
        {
            return o.GetHashCode().Equals(GetHashCode()) ? 0 : -1;
        }

        [Register("plus", "(JLorg/threeten/bp/temporal/TemporalUnit;)Lorg/threeten/bp/LocalDateTime;", "")]
        public override unsafe global::Org.Threeten.BP.Chrono.ChronoLocalDateTime Plus(long amountToAdd, global::Org.Threeten.BP.Temporal.ITemporalUnit unit)
        {
            const string __id = "plus.(JLorg/threeten/bp/temporal/TemporalUnit;)Lorg/threeten/bp/LocalDateTime;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(amountToAdd);
                __args[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Chrono.ChronoLocalDateTime>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("atZone", "(Lorg/threeten/bp/ZoneId;)Lorg/threeten/bp/ZonedDateTime;", "")]
        public override unsafe global::Org.Threeten.BP.Chrono.ChronoZonedDateTime AtZone(global::Org.Threeten.BP.ZoneId zone)
        {
            const string __id = "atZone.(Lorg/threeten/bp/ZoneId;)Lorg/threeten/bp/ZonedDateTime;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((zone == null) ? IntPtr.Zero : ((global::Java.Lang.Object)zone).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Chrono.ChronoZonedDateTime>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("toLocalDate", "()Lorg/threeten/bp/LocalDate;", "")]
        public override unsafe global::Java.Lang.Object ToLocalDate()
        {
            const string __id = "toLocalDate.()Lorg/threeten/bp/LocalDate;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("with", "(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/LocalDateTime;", "")]
        public override unsafe global::Org.Threeten.BP.Temporal.ITemporal With(global::Org.Threeten.BP.Temporal.ITemporalField field, long newValue)
        {
            const string __id = "with.(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/LocalDateTime;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object)field).Handle);
                __args[1] = new JniArgumentValue(newValue);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Temporal.ITemporal>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public partial class ZonedDateTime
    {
        public override global::System.Int32 CompareTo(global::Java.Lang.Object o)
        {
            return o.GetHashCode().Equals(GetHashCode()) ? 0 : -1;
        }

        [Register("with", "(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/ZonedDateTime;", "")]
        public unsafe override global::Org.Threeten.BP.Temporal.ITemporal With(global::Org.Threeten.BP.Temporal.ITemporalField field, long newValue)
        {
            const string __id = "with.(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/ZonedDateTime;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object)field).Handle);
                __args[1] = new JniArgumentValue(newValue);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Temporal.ITemporal>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        [Register("toLocalDateTime", "()Lorg/threeten/bp/LocalDateTime;", "")]
        public override unsafe global::Org.Threeten.BP.Chrono.ChronoLocalDateTime ToLocalDateTime()
        {
            const string __id = "toLocalDateTime.()Lorg/threeten/bp/LocalDateTime;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Chrono.ChronoLocalDateTime>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public partial class OffsetDateTime
    {
        [Register("with", "(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/OffsetDateTime;", "")]
        public override unsafe global::Org.Threeten.BP.Temporal.ITemporal With(global::Org.Threeten.BP.Temporal.ITemporalField field, long newValue)
        {
            const string __id = "with.(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/OffsetDateTime;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object)field).Handle);
                __args[1] = new JniArgumentValue(newValue);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Temporal.ITemporal>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}

namespace Org.Threeten.BP.Chrono
{
    public partial class ChronoLocalDate
    {
        [Register("with", "(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/temporal/Temporal;", "GetWith_Lorg_threeten_bp_temporal_TemporalField_JHandler")]
        public override unsafe global::Org.Threeten.BP.Temporal.ITemporal With(global::Org.Threeten.BP.Temporal.ITemporalField p0, long p1)
        {
            const string __id = "with.(Lorg/threeten/bp/temporal/TemporalField;J)Lorg/threeten/bp/temporal/Temporal;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                __args[1] = new JniArgumentValue(p1);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Org.Threeten.BP.Temporal.ITemporal>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public partial class IsoChronology
    {
        public override global::System.Int32 CompareTo(global::Java.Lang.Object o)
        {
            return o.GetHashCode().Equals(GetHashCode()) ? 0 : -1;
        }
    }
}
