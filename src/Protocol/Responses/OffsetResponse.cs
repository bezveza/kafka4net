﻿namespace kafka4net.Protocol.Responses
{
    class OffsetResponse
    {
        public string TopicName;
        public PartitionOffsetData[] Partitions;

        public class PartitionOffsetData
        {
            public int Partition;
            public ErrorCode ErrorCode;
            public long[] Offsets;
        }
    }
}