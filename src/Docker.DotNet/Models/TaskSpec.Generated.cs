using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class TaskSpec // (swarm.TaskSpec)
    {
        [DataMember(Name = "ContainerSpec", EmitDefaultValue = false)]
        public ContainerSpec ContainerSpec { get; set; }

        [DataMember(Name = "Resources", EmitDefaultValue = false)]
        public ResourceRequirements Resources { get; set; }

        [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
        public RestartPolicy RestartPolicy { get; set; }

        [DataMember(Name = "Placement", EmitDefaultValue = false)]
        public Placement Placement { get; set; }

        [DataMember(Name = "Networks", EmitDefaultValue = false)]
        public IList<NetworkAttachmentConfig> Networks { get; set; }

        [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
        public Driver LogDriver { get; set; }

        [DataMember(Name = "ForceUpdate", EmitDefaultValue = false)]
        public ulong ForceUpdate { get; set; }
    }
}
