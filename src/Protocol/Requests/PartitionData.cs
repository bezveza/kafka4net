﻿using System.Collections.Generic;

namespace kafka4net.Protocol.Requests
{
    class PartitionData
    {
        public int Partition;
        // is calculated at serizlization time
        //public int MessageSetSize;
        public IEnumerable<MessageData> Messages;

        /// <summary>Is not serialized. Is carried through to send error/success notifications
        /// if herror happen</summary>
        public Publisher Pub;

        /// <summary>
        /// Not serialized.
        /// Copy of origianl, application provided messages. Is needed when error happen
        /// and driver notifys app that those messages have failed.
        /// </summary>
        public Message[] OriginalMessages;
    }
}